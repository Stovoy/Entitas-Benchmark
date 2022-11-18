using System.Diagnostics;

public class Runner {
    public static void Main() {
        // These benchmarks are made to be 1:1 with https://github.com/noctjs/ecs-benchmark
        Console.WriteLine("Running Entitas Benchmark");
        var benchmarks = new (Benchable, int)[] {
            (new Packed5(), 1000),
            (new SimpleIter(), 1000),
            (new FragIter(), 100),
            (new EntityCycle(), 1000),
            (new AddRemove(), 1000)
        };

        foreach (var (benchmark, count) in benchmarks) {
            benchmark.Initialize(count);

            var cycleN = 1;
            float cycleMs = 0;
            float cycleTotalMs = 0;
            while (cycleTotalMs < 500) {
                var elapsed = RunIteration(benchmark, cycleN);
                cycleMs = elapsed / (float) cycleN;
                cycleN *= 2;
                cycleTotalMs += elapsed;
            }

            if (cycleMs == 0) {
                cycleMs = 1;
            }

            var targetN = 500 / cycleMs;
            var totalMs = RunIteration(benchmark, (int) targetN);
            var hz = targetN / totalMs * 1000;

            Console.WriteLine(
                $"{string.Concat(benchmark.ToString()!.Select((x, i) => i > 0 && char.IsUpper(x) || char.IsDigit(x) ? "_" + x : x.ToString())).ToLower()}");
            Console.WriteLine($"{Math.Floor(hz):n0} op/s");
        }
    }

    private static long RunIteration(Benchable benchmark, int count) {
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        for (var i = 0; i < count; i++) {
            benchmark.Run();
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}

public interface Benchable {
    public void Initialize(int count);
    public void Run();
}

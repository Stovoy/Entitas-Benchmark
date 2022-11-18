using Entitas;

public class SimpleIter : Benchable {
    private GameContext ctx;
    private IGroup<GameEntity> groupAB;
    private IGroup<GameEntity> groupCD;
    private IGroup<GameEntity> groupCE;

    public SimpleIter() {
        ctx = new GameContext();
        groupAB = ctx.GetGroup(GameMatcher.AllOf(GameMatcher.AValue, GameMatcher.BValue));
        groupCD = ctx.GetGroup(GameMatcher.AllOf(GameMatcher.CValue, GameMatcher.DValue));
        groupCE = ctx.GetGroup(GameMatcher.AllOf(GameMatcher.CValue, GameMatcher.EValue));
    }

    public void Initialize(int count) {
        for (var i = 0; i < count; i++) {
            var ab = ctx.CreateEntity();
            var abc = ctx.CreateEntity();
            var abcd = ctx.CreateEntity();
            var abce = ctx.CreateEntity();
            ab.AddAValue(0);
            ab.AddBValue(0);

            abc.AddAValue(0);
            abc.AddBValue(0);
            abc.AddCValue(0);

            abcd.AddAValue(0);
            abcd.AddBValue(0);
            abcd.AddCValue(0);
            abcd.AddDValue(0);

            abce.AddAValue(0);
            abce.AddBValue(0);
            abce.AddCValue(0);
            abce.AddEValue(0);
        }
    }

    public void Run() {
        foreach (var e in groupAB.GetEntities()) {
            var temp = e.aValue.V;
            e.ReplaceAValue(e.bValue.V);
            e.ReplaceBValue(temp);
        }

        foreach (var e in groupCD.GetEntities()) {
            var temp = e.cValue.V;
            e.ReplaceCValue(e.dValue.V);
            e.ReplaceDValue(temp);
        }

        foreach (var e in groupCE.GetEntities()) {
            var temp = e.cValue.V;
            e.ReplaceCValue(e.eValue.V);
            e.ReplaceEValue(temp);
        }
    }
}

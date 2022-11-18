using Entitas;

public class EntityCycle : Benchable {
    private GameContext ctx;
    private IGroup<GameEntity> groupA;
    private IGroup<GameEntity> groupB;

    public EntityCycle() {
        ctx = new GameContext();
        groupA = ctx.GetGroup(GameMatcher.A);
        groupB = ctx.GetGroup(GameMatcher.B);
    }

    public void Initialize(int count) {
        for (var i = 0; i < count; i++) {
            var e = ctx.CreateEntity();
            e.isA = true;
        }
    }

    public void Run() {
        foreach (var _ in groupA.GetEntities()) {
            var newEntity = ctx.CreateEntity();
            newEntity.isB = true;
        }

        foreach (var e in groupB.GetEntities()) {
            e.Destroy();
        }
    }
}

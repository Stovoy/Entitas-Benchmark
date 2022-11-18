using Entitas;

public class AddRemove : Benchable {
    private GameContext ctx;
    private IGroup<GameEntity> groupA;
    private IGroup<GameEntity> groupB;

    public AddRemove() {
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
        foreach (var e in groupA.GetEntities()) {
            e.isB = true;
        }

        foreach (var e in groupB.GetEntities()) {
            e.isB = false;
        }
    }
}

using Entitas;

public class Packed5 : Benchable {
    private GameContext ctx;
    private IGroup<GameEntity> groupA;
    private IGroup<GameEntity> groupB;
    private IGroup<GameEntity> groupC;
    private IGroup<GameEntity> groupD;
    private IGroup<GameEntity> groupE;

    public Packed5() {
        ctx = new GameContext();
        groupA = ctx.GetGroup(GameMatcher.AValue);
        groupB = ctx.GetGroup(GameMatcher.BValue);
        groupC = ctx.GetGroup(GameMatcher.CValue);
        groupD = ctx.GetGroup(GameMatcher.DValue);
        groupE = ctx.GetGroup(GameMatcher.EValue);
    }

    public void Initialize(int count) {
        for (var i = 0; i < count; i++) {
            var e = ctx.CreateEntity();
            e.AddAValue(1);
            e.AddBValue(1);
            e.AddCValue(1);
            e.AddDValue(1);
            e.AddEValue(1);
        }
    }

    public void Run() {
        foreach (var e in groupA.GetEntities()) {
            e.ReplaceAValue(e.aValue.V * 2);
        }

        foreach (var e in groupB.GetEntities()) {
            e.ReplaceBValue(e.bValue.V * 2);
        }

        foreach (var e in groupC.GetEntities()) {
            e.ReplaceCValue(e.cValue.V * 2);
        }

        foreach (var e in groupD.GetEntities()) {
            e.ReplaceDValue(e.dValue.V * 2);
        }

        foreach (var e in groupE.GetEntities()) {
            e.ReplaceEValue(e.eValue.V * 2);
        }
    }
}

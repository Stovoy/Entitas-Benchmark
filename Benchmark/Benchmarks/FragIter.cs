using Entitas;

public class FragIter : Benchable {
    private GameContext ctx;
    private IGroup<GameEntity> groupData;
    private IGroup<GameEntity> groupZ;

    public FragIter() {
        ctx = new GameContext();
        groupData = ctx.GetGroup(GameMatcher.Data);
        groupZ = ctx.GetGroup(GameMatcher.ZValue);
    }

    public void Initialize(int count) {
        var map = new Dictionary<int, Action<GameEntity>> {
            {0, e => e.AddAValue(1)},
            {1, e => e.AddBValue(1)},
            {2, e => e.AddCValue(1)},
            {3, e => e.AddDValue(1)},
            {4, e => e.AddEValue(1)},
            {5, e => e.AddFValue(1)},
            {6, e => e.AddGValue(1)},
            {7, e => e.AddHValue(1)},
            {8, e => e.AddIValue(1)},
            {9, e => e.AddJValue(1)},
            {10, e => e.AddKValue(1)},
            {11, e => e.AddLValue(1)},
            {12, e => e.AddMValue(1)},
            {13, e => e.AddNValue(1)},
            {14, e => e.AddOValue(1)},
            {15, e => e.AddPValue(1)},
            {16, e => e.AddQValue(1)},
            {17, e => e.AddRValue(1)},
            {18, e => e.AddSValue(1)},
            {19, e => e.AddTValue(1)},
            {20, e => e.AddUValue(1)},
            {21, e => e.AddVValue(1)},
            {22, e => e.AddWValue(1)},
            {23, e => e.AddXValue(1)},
            {24, e => e.AddYValue(1)},
            {25, e => e.AddZValue(1)}
        };

        for (var i = 0; i < count; i++) {
            var e = ctx.CreateEntity();
            for (var j = 0; j < 26; j++) {
                map[j](e);
            }

            e.AddData(1);
        }
    }

    public void Run() {
        foreach (var e in groupData.GetEntities()) {
            e.ReplaceData(e.data.V * 2);
        }

        foreach (var e in groupZ.GetEntities()) {
            e.ReplaceZValue(e.zValue.V * 2);
        }
    }
}

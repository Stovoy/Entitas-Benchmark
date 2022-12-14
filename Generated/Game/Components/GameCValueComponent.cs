//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CValue cValue { get { return (CValue)GetComponent(GameComponentsLookup.CValue); } }
    public bool hasCValue { get { return HasComponent(GameComponentsLookup.CValue); } }

    public void AddCValue(int newV) {
        var index = GameComponentsLookup.CValue;
        var component = (CValue)CreateComponent(index, typeof(CValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceCValue(int newV) {
        var index = GameComponentsLookup.CValue;
        var component = (CValue)CreateComponent(index, typeof(CValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveCValue() {
        RemoveComponent(GameComponentsLookup.CValue);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCValue;

    public static Entitas.IMatcher<GameEntity> CValue {
        get {
            if (_matcherCValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCValue = matcher;
            }

            return _matcherCValue;
        }
    }
}

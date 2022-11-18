//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AValue aValue { get { return (AValue)GetComponent(GameComponentsLookup.AValue); } }
    public bool hasAValue { get { return HasComponent(GameComponentsLookup.AValue); } }

    public void AddAValue(int newV) {
        var index = GameComponentsLookup.AValue;
        var component = (AValue)CreateComponent(index, typeof(AValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceAValue(int newV) {
        var index = GameComponentsLookup.AValue;
        var component = (AValue)CreateComponent(index, typeof(AValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveAValue() {
        RemoveComponent(GameComponentsLookup.AValue);
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

    static Entitas.IMatcher<GameEntity> _matcherAValue;

    public static Entitas.IMatcher<GameEntity> AValue {
        get {
            if (_matcherAValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAValue = matcher;
            }

            return _matcherAValue;
        }
    }
}
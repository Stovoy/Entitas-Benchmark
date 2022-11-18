//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public NValue nValue { get { return (NValue)GetComponent(GameComponentsLookup.NValue); } }
    public bool hasNValue { get { return HasComponent(GameComponentsLookup.NValue); } }

    public void AddNValue(int newV) {
        var index = GameComponentsLookup.NValue;
        var component = (NValue)CreateComponent(index, typeof(NValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceNValue(int newV) {
        var index = GameComponentsLookup.NValue;
        var component = (NValue)CreateComponent(index, typeof(NValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveNValue() {
        RemoveComponent(GameComponentsLookup.NValue);
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

    static Entitas.IMatcher<GameEntity> _matcherNValue;

    public static Entitas.IMatcher<GameEntity> NValue {
        get {
            if (_matcherNValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNValue = matcher;
            }

            return _matcherNValue;
        }
    }
}

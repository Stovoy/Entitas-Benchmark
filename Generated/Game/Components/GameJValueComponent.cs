//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public JValue jValue { get { return (JValue)GetComponent(GameComponentsLookup.JValue); } }
    public bool hasJValue { get { return HasComponent(GameComponentsLookup.JValue); } }

    public void AddJValue(int newV) {
        var index = GameComponentsLookup.JValue;
        var component = (JValue)CreateComponent(index, typeof(JValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceJValue(int newV) {
        var index = GameComponentsLookup.JValue;
        var component = (JValue)CreateComponent(index, typeof(JValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveJValue() {
        RemoveComponent(GameComponentsLookup.JValue);
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

    static Entitas.IMatcher<GameEntity> _matcherJValue;

    public static Entitas.IMatcher<GameEntity> JValue {
        get {
            if (_matcherJValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.JValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherJValue = matcher;
            }

            return _matcherJValue;
        }
    }
}
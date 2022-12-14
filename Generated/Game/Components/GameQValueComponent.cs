//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public QValue qValue { get { return (QValue)GetComponent(GameComponentsLookup.QValue); } }
    public bool hasQValue { get { return HasComponent(GameComponentsLookup.QValue); } }

    public void AddQValue(int newV) {
        var index = GameComponentsLookup.QValue;
        var component = (QValue)CreateComponent(index, typeof(QValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceQValue(int newV) {
        var index = GameComponentsLookup.QValue;
        var component = (QValue)CreateComponent(index, typeof(QValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveQValue() {
        RemoveComponent(GameComponentsLookup.QValue);
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

    static Entitas.IMatcher<GameEntity> _matcherQValue;

    public static Entitas.IMatcher<GameEntity> QValue {
        get {
            if (_matcherQValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.QValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherQValue = matcher;
            }

            return _matcherQValue;
        }
    }
}

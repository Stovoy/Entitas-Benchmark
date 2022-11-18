//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public IValue iValue { get { return (IValue)GetComponent(GameComponentsLookup.IValue); } }
    public bool hasIValue { get { return HasComponent(GameComponentsLookup.IValue); } }

    public void AddIValue(int newV) {
        var index = GameComponentsLookup.IValue;
        var component = (IValue)CreateComponent(index, typeof(IValue));
        component.V = newV;
        AddComponent(index, component);
    }

    public void ReplaceIValue(int newV) {
        var index = GameComponentsLookup.IValue;
        var component = (IValue)CreateComponent(index, typeof(IValue));
        component.V = newV;
        ReplaceComponent(index, component);
    }

    public void RemoveIValue() {
        RemoveComponent(GameComponentsLookup.IValue);
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

    static Entitas.IMatcher<GameEntity> _matcherIValue;

    public static Entitas.IMatcher<GameEntity> IValue {
        get {
            if (_matcherIValue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.IValue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIValue = matcher;
            }

            return _matcherIValue;
        }
    }
}

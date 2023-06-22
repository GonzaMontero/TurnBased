using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Element")]
public class ElementScriptable : ScriptableObject
{
    public string elementName;

    public ElementScriptable[] elementStrongAgainst;
    public ElementScriptable[] elementWeakAgainst;

    public StatusEffectScriptable statusToInflict;
    public float chancesToInflict;
}

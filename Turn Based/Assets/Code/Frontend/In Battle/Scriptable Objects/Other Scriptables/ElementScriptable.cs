using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Others/Element")]
public class ElementScriptable : ScriptableObject
{
    public string elementKey;

    public ElementScriptable[] elementStrongAgainst;
    public ElementScriptable[] elementWeakAgainst;

    public StatusEffectScriptable statusToInflict;
    public float chancesToInflict;
}

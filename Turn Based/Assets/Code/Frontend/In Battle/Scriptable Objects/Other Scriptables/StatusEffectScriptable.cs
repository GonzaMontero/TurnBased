using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Others/Status Effect")]
public class StatusEffectScriptable : ScriptableObject
{
    public string statusKey;

    public bool statusLowersStat;
    public StatData.StatTypes statToLower;
    [Range(1, 6)]
    public int stagesToLower;

    public bool lowersHealthPerTurn;
    public float healthPercentageToLower;
}

using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObjects/Status Effect")]
public class StatusEffectScriptable : ScriptableObject
{
    public string statusName;

    public bool statusLowersStat;
    public IngameCharacterManager.StatTypes statToLower;
    [Range(1, 6)]
    public int stagesToLower;

    public bool lowersHealthPerTurn;
    public float healthPercentageToLower;
}

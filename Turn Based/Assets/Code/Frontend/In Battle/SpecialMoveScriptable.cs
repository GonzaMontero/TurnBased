using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/SpecialMove")]
public class SpecialMoveScriptable : BaseMoveScriptable
{
    [Header("Element")]
    public CharacterStats.Elements element;

    [Header("If false, ignore all posterior toggles")]
    public bool moveHasSecondaryEffects;

    [Header("Move has Recoil for user")]
    public bool moveHasRecoil;
    public int moveRecoilPercentage;

    [Header("Move Lowers Player Stats")]
    public bool moveLowersPlayerStat;
    public CharacterStats.StatTypes[] statToLowerPlayer;
    [Range(1,6)]
    public int stagesToReducePlayerStat;

    [Header("Move Lowers Enemy Stats")]
    public bool moveLowersEnemyStat;
    public CharacterStats.StatTypes[] statToLowerEnemy;
    [Range(1, 6)]
    public int stagesToReduceEnemyStat;
}

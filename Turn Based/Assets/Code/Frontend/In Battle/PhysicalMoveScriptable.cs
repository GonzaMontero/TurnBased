using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/PhysicalMove")]
public class PhysicalMoveScriptable : BaseMoveScriptable
{
    public bool moveHasSecondaryEffects;

    public bool moveHasRecoil;
    public int moveRecoilPercentage;

    public bool moveLowersPlayerStat;
    public CharacterStats.StatTypes[] statToLowerPlayer;
    [Range(1, 6)]
    public int stagesToReducePlayerStat;

    public bool moveLowersEnemyStat;
    public CharacterStats.StatTypes[] statToLowerEnemy;
    [Range(1, 6)]
    public int stagesToReduceEnemyStat;
}

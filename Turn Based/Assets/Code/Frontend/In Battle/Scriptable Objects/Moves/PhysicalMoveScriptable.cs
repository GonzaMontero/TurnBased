using UnityEngine;

[CreateAssetMenu(fileName = "Special Move", menuName = "ScriptableObjects/Moves/PhysicalMove")]
public class PhysicalMoveScriptable : BaseMoveScriptable
{
    public bool moveHasSecondaryEffects;

    public bool moveHasRecoil;
    public int moveRecoilPercentage;

    public bool moveLowersPlayerStat;
    public IngameCharacterManager.StatTypes[] statToLowerPlayer;
    [Range(1, 6)]
    public int stagesToReducePlayerStat;

    public bool moveLowersEnemyStat;
    public IngameCharacterManager.StatTypes[] statToLowerEnemy;
    [Range(1, 6)]
    public int stagesToReduceEnemyStat;
}

using UnityEngine;

public class CharacterInBattleManager : MonoBehaviourSingleton<CharacterInBattleManager>
{
    public void UsePhysicalMove(PhysicalMoveScriptable moveUsed, CharacterStats target, CharacterStats user)
    {
        int attackAccuracy = Random.Range(1, 100);

        if (attackAccuracy >= moveUsed.moveAccuracy)
        {
            target.TakeDamage(Mathf.RoundToInt(moveUsed.moveDamage * user.characterAttack));

            if (moveUsed.moveHasRecoil)
                user.TakeDamage(user.characterHealth * moveUsed.moveRecoilPercentage);
            if (moveUsed.moveLowersPlayerStat)
            {
                for(short i = 0; i < moveUsed.statToLowerPlayer.Length; i++)
                    user.LowerStat(moveUsed.statToLowerPlayer[i], moveUsed.stagesToReducePlayerStat);
            }
            if (moveUsed.moveLowersEnemyStat)
            {
                for (short i = 0; i < moveUsed.statToLowerEnemy.Length; i++)
                    user.LowerStat(moveUsed.statToLowerEnemy[i], moveUsed.stagesToReduceEnemyStat);
            }

        }
        else
            Debug.Log("Attack Missed!");
    }

    public void UseSpecialMove(SpecialMoveScriptable moveUsed, CharacterStats target, CharacterStats user)
    {
        int attackAccuracy = Random.Range(1, 100);

        if (attackAccuracy >= moveUsed.moveAccuracy)
        {
            target.TakeDamage(Mathf.RoundToInt(moveUsed.moveDamage * user.characterSpecialAttack));

            if (moveUsed.moveHasRecoil)
                user.TakeDamage(user.characterHealth * moveUsed.moveRecoilPercentage);
            if (moveUsed.moveLowersPlayerStat)
            {
                for (short i = 0; i < moveUsed.statToLowerPlayer.Length; i++)
                    user.LowerStat(moveUsed.statToLowerPlayer[i], moveUsed.stagesToReducePlayerStat);
            }
            if (moveUsed.moveLowersEnemyStat)
            {
                for (short i = 0; i < moveUsed.statToLowerEnemy.Length; i++)
                    user.LowerStat(moveUsed.statToLowerEnemy[i], moveUsed.stagesToReduceEnemyStat);
            }
        }
        else
            Debug.Log("Attack Missed!");
    }
}

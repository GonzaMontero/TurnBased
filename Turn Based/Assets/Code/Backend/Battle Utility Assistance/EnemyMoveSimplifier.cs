using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveSimplifier
{
    public List<BaseMoveScriptable> SelectMoves(List<EnemyMovePair> enemyMoves)
    {
        List<BaseMoveScriptable> selectedMoves = new();

        CharacterInBattleManager battleManager = CharacterInBattleManager.Get();

        for (short i = 0; i < enemyMoves.Count; i++)
        {
            if (enemyMoves[i].move != null)
            {
                for (short j = 0; j < enemyMoves[i].moveSetups.Count; j++)
                {
                    switch (enemyMoves[i].moveSetups[j].moveBehavior)
                    {
                        case EnemyScriptable.MoveBehavior.HealthHigherThan:
                            if (HandleHealthLesGreaterThan(battleManager.enemyStats.enemyHealth,
                                enemyMoves[i].moveSetups[j].percentage,
                                true))
                            {
                                selectedMoves.Add(enemyMoves[i].move);
                            }
                            break;

                        case EnemyScriptable.MoveBehavior.HealthLowerThan:
                            if (HandleHealthLesGreaterThan(battleManager.enemyStats.enemyHealth,
                                enemyMoves[i].moveSetups[j].percentage,
                                false))
                            {
                                selectedMoves.Add(enemyMoves[i].move);
                            }
                            break;

                        case EnemyScriptable.MoveBehavior.PlayerStatHigherThan:
                        case EnemyScriptable.MoveBehavior.PlayerStatLowerThan:
                            //if (HandlePlayerStatLesGreaterThan(enemyMoves[i].moveSetups[j].statType,
                            //battleManager.playerStats, enemyMoves[i].moveSetups[j].statStage, true))
                            //{
                            //    selectedMoves.Add(enemyMoves[i].move);
                            //}
                            break;

                        case EnemyScriptable.MoveBehavior.EnemyStatHigherThan:
                        case EnemyScriptable.MoveBehavior.EnemyStatLowerThan:

                            break;

                        case EnemyScriptable.MoveBehavior.InflictedWithStatus:
                            if (HandleStatusInflicted(IngameCharacterManager.Get()))
                            {
                                selectedMoves.Add(enemyMoves[i].move);
                            }
                            break;
                    }
                }
            }
        }

        return selectedMoves;
    }

    public bool HandleHealthLesGreaterThan(int health, float healthPercentage, bool isGreater)
    {
        if (isGreater)
        {
            return health > ((health / 100) * healthPercentage);
        }
        else
        {
            return health < ((health / 100) * healthPercentage);
        }
    }

    public bool HandlePlayerStatLesGreaterThan(StatData.StatTypes statToCheck, IngameCharacterManager playerToCheck, 
         int statStageNeeded, bool greaterThan)
    {
        switch (statToCheck)
        {
            case StatData.StatTypes.Attack:
                if (greaterThan)
                    return playerToCheck.characterAttackData.statStage > statStageNeeded;
                else
                    return playerToCheck.characterAttackData.statStage < statStageNeeded;

            case StatData.StatTypes.Special_Attack:
                if (greaterThan)
                    return playerToCheck.characterSpecialAttackData.statStage > statStageNeeded;
                else
                    return playerToCheck.characterSpecialAttackData.statStage < statStageNeeded;

            case StatData.StatTypes.Defense:
                if (greaterThan)
                    return playerToCheck.characterDefenseData.statStage > statStageNeeded;
                else
                    return playerToCheck.characterDefenseData.statStage < statStageNeeded;

            case StatData.StatTypes.Special_Defense:
                if (greaterThan)
                    return playerToCheck.characterSpecialDefenseData.statStage > statStageNeeded;
                else
                    return playerToCheck.characterSpecialDefenseData.statStage < statStageNeeded;

            case StatData.StatTypes.Speed:
                if (greaterThan)
                    return playerToCheck.characterSpeedData.statStage > statStageNeeded;
                else
                    return playerToCheck.characterSpeedData.statStage < statStageNeeded;  

            default:
                return false;
        }
    }

    public bool HandleStatusInflicted(IngameCharacterManager character)
    {
        return false;
    }
}

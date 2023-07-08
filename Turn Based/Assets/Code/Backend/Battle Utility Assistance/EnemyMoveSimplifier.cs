using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveSimplifier
{
    public List<BaseMoveScriptable> SelectMoves(List<EnemyMovePair> enemyMoves)
    {
        List<BaseMoveScriptable> selectedMoves = new();

        for (short i = 0; i < enemyMoves.Count; i++)
        {
            if (enemyMoves[i].move != null)
            {

                for (short j = 0; j < enemyMoves[i].moveSetups.Count; j++)
                {
                    switch (enemyMoves[i].moveSetups[j].moveBehavior)
                    {
                        case EnemyScriptable.MoveBehavior.HealthHigherThan:
                            if (HandleHealthLesGreaterThan(CharacterInBattleManager.Get().enemyStats.characterHealth, 
                                enemyMoves[i].moveSetups[j].percentage, 
                                true))
                            {
                                selectedMoves.Add(enemyMoves[i].move);
                            }
                            break;

                        case EnemyScriptable.MoveBehavior.HealthLowerThan:
                            if (HandleHealthLesGreaterThan(CharacterInBattleManager.Get().enemyStats.characterHealth, 
                                enemyMoves[i].moveSetups[j].percentage, 
                                false))
                            {
                                selectedMoves.Add(enemyMoves[i].move);
                            }
                            break;

                        case EnemyScriptable.MoveBehavior.PlayerStatHigherThan:
                        case EnemyScriptable.MoveBehavior.EnemyStatHigherThan:
                            //if (HandleStatLesGreaterThan(enemyMoves[i].moveSetups[j].percentage, 
                            //    enemyMoves[i].moveSetups[j].percentage, 
                            //    true))
                            //{
                            //    selectedMoves.Add(enemyMoves[i].move);
                            //}
                            break;

                        case EnemyScriptable.MoveBehavior.PlayerStatLowerThan:
                        case EnemyScriptable.MoveBehavior.EnemyStatLowerThan:
                            //if (HandleStatLesGreaterThan(enemyMoves[i].moveSetups[j].percentage, 
                            //    enemyMoves[i].moveSetups[j].percentage, 
                            //    true))
                            //{
                            //    selectedMoves.Add(enemyMoves[i].move);
                            //}
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

    public bool HandleStatLesGreaterThan(int statStage, int statStageNeeded, bool isPlayer)
    {
        return false;
    }

    public bool HandleStatusInflicted(IngameCharacterManager character)
    {
        return false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Characters/Enemy")]
public class EnemyScriptable : ScriptableObject
{
    public enum MoveBehavior
    {
        HealthLowerThan,
        HealthHigherThan,
        EnemyStatHigherThan,
        EnemyStatLowerThan,
        PlayerStatHigherThan,
        PlayerStatLowerThan,
        InflictedWithStatus
    }

    public int characterHealth;
    public float characterAttack;
    public float characterSpecialAttack;
    public float characterDefense;
    public float characterSpecialDefense;
    public float characterSpeed;

    public List<EnemyMovePair> enemyMoves = new();
}

#region Game Design Assistance
[System.Serializable]
public class EnemyMovePair
{
    public BaseMoveScriptable move;
    public List<EnemyMoveSetup> moveSetups = new();
}

[System.Serializable]
public class EnemyMoveSetup
{
    public EnemyScriptable.MoveBehavior moveBehavior;
    public float percentage;
}
#endregion
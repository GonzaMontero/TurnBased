using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Enemy")]
public class EnemyScriptable : ScriptableObject
{
    public enum MoveBehavior
    {
        HealthLowerThan,
        HealthHigherThan,
        PlayerHealthLowerThan,
        PlayerHealthHigherThan,
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

    public EnemyMovePair[] enemyMoves = new EnemyMovePair[4];
}

[System.Serializable]
public class EnemyMovePair
{
    public BaseMoveScriptable move;
    public List<EnemyScriptable.MoveBehavior> behaviorForMove = new List<EnemyScriptable.MoveBehavior>();
    public List<float> percentage = new List<float>();
}

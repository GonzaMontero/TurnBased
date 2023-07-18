using System;
using System.Collections.Generic;

public class EnemyInBattleManager : MonoBehaviourSingletonInScene<EnemyInBattleManager>
{
    public EnemyScriptable enemyScriptable;
    public static event Action OnDeath;

    public ElementScriptable element;

    public int enemyHealth; //Health is handled differently from other stat Types, since it cannot be increased by stages
    public StatData enemyAttackData;
    public StatData enemySpecialAttackData;
    public StatData enemyDefenseData;
    public StatData enemySpecialDefenseData;
    public StatData enemySpeedData;

    public List<EnemyMovePair> moves = new();

    #region Setup and Load
    /// <summary>
    /// When the player loads into the battle, this script will load the data from the corresponding enemy scriptable object
    /// </summary>
    private void Start()
    {
        LoadDataFromScriptable();
    }

    private void LoadDataFromScriptable()
    {
        moves = enemyScriptable.enemyMoves;

        enemyHealth = enemyScriptable.characterHealth; //Set up health

        enemyAttackData.statType = StatData.StatTypes.Attack; //Set up stat type
        enemyAttackData.statValue = enemyScriptable.characterAttack; //Get the value from the scriptable object
        enemyAttackData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        enemySpecialAttackData.statType = StatData.StatTypes.Special_Attack; //Set up stat type
        enemySpecialAttackData.statValue = enemyScriptable.characterSpecialAttack; //Get the value from the scriptable object
        enemySpecialAttackData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        enemyDefenseData.statType = StatData.StatTypes.Defense; //Set up stat type
        enemyDefenseData.statValue = enemyScriptable.characterDefense; //Get the value from the scriptable object
        enemyDefenseData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        enemySpecialDefenseData.statType = StatData.StatTypes.Special_Defense; //Set up stat type
        enemySpecialDefenseData.statValue = enemyScriptable.characterSpecialDefense; //Get the value from the scriptable object
        enemySpecialDefenseData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        enemySpeedData.statType = StatData.StatTypes.Speed; //Set up stat type
        enemySpeedData.statValue = enemyScriptable.characterSpeed; //Get the value from the scriptable object
        enemySpeedData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)
    }
    #endregion
}
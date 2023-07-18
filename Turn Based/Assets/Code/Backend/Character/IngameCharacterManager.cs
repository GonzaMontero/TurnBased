using System;
using System.Collections.Generic;

/// <summary>
/// Class that Loads the Player´s Character Data from the Scriptable Object and handles the Stat Changes and Calculations
/// </summary>
public class IngameCharacterManager : MonoBehaviourSingleton<IngameCharacterManager>
{
    public CharacterScriptable characterScriptable;
    public static event Action OnDeath;

    public ElementScriptable element;

    public int characterHealth; //Health is handled differently from other stat Types, since it cannot be increased by stages
    public StatData characterAttackData;
    public StatData characterSpecialAttackData;
    public StatData characterDefenseData;
    public StatData characterSpecialDefenseData;
    public StatData characterSpeedData;

    public List<BaseMoveScriptable> moves = new();

    #region Setup and Load
    /// <summary>
    /// When the player loads into the game, this is the function that will either load data from the selected character
    /// or load the data in a saved game
    /// </summary>
    private void Start()
    {
        //if (SaveGameManager.hasSavedGame)
        //{
        //      LoadDataFromSaveGame();
        //}
        //else
        //{
        //    LoadDataFromScriptable();
        //}


        LoadDataFromScriptable();
    }

    /// <summary>
    /// This function will be called when the player is not loading a saved game
    /// </summary>
    private void LoadDataFromScriptable()
    {
        moves = characterScriptable.characterMoves;

        characterHealth = characterScriptable.characterHealth; //Set up health

        characterAttackData.statType = StatData.StatTypes.Attack; //Set up stat type
        characterAttackData.statValue = characterScriptable.characterAttack; //Get the value from the scriptable object
        characterAttackData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        characterSpecialAttackData.statType = StatData.StatTypes.Special_Attack; //Set up stat type
        characterSpecialAttackData.statValue = characterScriptable.characterSpecialAttack; //Get the value from the scriptable object
        characterSpecialAttackData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        characterDefenseData.statType = StatData.StatTypes.Defense; //Set up stat type
        characterDefenseData.statValue = characterScriptable.characterDefense; //Get the value from the scriptable object
        characterDefenseData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        characterSpecialDefenseData.statType = StatData.StatTypes.Special_Defense; //Set up stat type
        characterSpecialDefenseData.statValue = characterScriptable.characterSpecialDefense; //Get the value from the scriptable object
        characterSpecialDefenseData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)

        characterSpeedData.statType = StatData.StatTypes.Speed; //Set up stat type
        characterSpeedData.statValue = characterScriptable.characterSpeed; //Get the value from the scriptable object
        characterSpeedData.statStage = 0; //Set the stage to 0 (neither increased nor decreased)
    }

    /// <summary>
    /// This function will be called when the player is loading a saved game
    /// </summary>
    private void LoadDataFromSave()
    {

    }
    #endregion
}
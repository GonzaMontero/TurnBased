using UnityEngine;
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

    public enum StatTypes
    {
        Attack, Special_Attack, Defense, Special_Defense, Speed
    }

    private int characterHealth; //Value is int due to the fact that the health is only displayed in whole numbers

    private float characterAttack; //Value is float due to the fact that the attack is calculated with decimal numbers
    private float characterSpecialAttack; //Value is float due to the fact that the attack is calculated with decimal numbers

    private float characterDefense; //Value is float due to the fact that the defense is calculated with decimal numbers
    private float characterSpecialDefense; //Value is float due to the fact that the defense is calculated with decimal numbers

    private float characterSpeed; //Value is float due to the fact that the speed is calculated with decimal numbers

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

    private void LoadDataFromScriptable()
    {
        moves = characterScriptable.characterMoves;

        characterHealth = characterScriptable.characterHealth;
        characterAttack = characterScriptable.characterAttack;
        characterSpecialAttack = characterScriptable.characterSpecialAttack;
        characterDefense = characterScriptable.characterDefense;
        characterSpecialDefense = characterScriptable.characterSpecialDefense;
        characterSpeed = characterScriptable.characterHealth;
    }
    #endregion
}

using UnityEngine;
using System;
using System.Collections;

public class CharacterStats : MonoBehaviour
{
    //  public CharacterScriptable characterScriptable;
    public static event Action OnDeath;

    public ElementScriptable element;

    public enum StatTypes
    {
        Attack, Special_Attack, Defense, Special_Defense, Speed
    }
    public float characterAttack;
    public float characterSpecialAttack;
    public float characterDefense;
    public float characterSpecialDefense;
    public float characterSpeed;
    public int characterHealth;

    #region Setup and Load
    private void LoadDataFromScriptable()
    {

    }
    #endregion

    #region Stat Changes and Calculations
    public void LowerStat(StatTypes statToChange, float statChangeRequired)
    {
        float percentage = 0;
        switch (statToChange)
        {
            case StatTypes.Attack:
                percentage = characterAttack / 2;
                characterAttack -= percentage;
                break;
            case StatTypes.Special_Attack:
                percentage = characterSpecialAttack / 2;
                characterSpecialAttack -= percentage;
                break;
            case StatTypes.Defense:
                percentage = characterDefense / 2;
                characterDefense -= percentage;
                break;
            case StatTypes.Special_Defense:
                percentage = characterSpecialDefense / 2;
                characterSpecialDefense -= percentage;
                break;
            case StatTypes.Speed:
                percentage = characterSpeed / 2;
                characterSpeed -= percentage;
                break;
        }
    }

    public void IncreaseStat(StatTypes statToChange, float statChangeRequired)
    {
        float percentage = 0;
        switch (statToChange)
        {
            case StatTypes.Attack:
                percentage = characterAttack / 2;
                characterAttack += percentage;
                break;
            case StatTypes.Special_Attack:
                percentage = characterSpecialAttack / 2;
                characterSpecialAttack += percentage;
                break;
            case StatTypes.Defense:
                percentage = characterDefense / 2;
                characterDefense += percentage;
                break;
            case StatTypes.Special_Defense:
                percentage = characterSpecialDefense / 2;
                characterSpecialDefense += percentage;
                break;
            case StatTypes.Speed:
                percentage = characterSpeed / 2;
                characterSpeed += percentage;
                break;
        }
    }

    public void TakeDamage(int damageTaken)
    {
        characterHealth -= damageTaken;
        if (characterHealth <= 0)
            OnDeath?.Invoke();
    }
    #endregion
}

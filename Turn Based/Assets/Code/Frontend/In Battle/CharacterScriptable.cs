using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character")]
public class CharacterScriptable: ScriptableObject
{
    public int characterHealth;
    public float characterAttack;
    public float characterSpecialAttack;
    public float characterDefense;
    public float characterSpecialDefense;
    public float characterSpeed;

    public List<BaseMoveScriptable> characterMoves;
}
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/BaseMove")]
public class BaseMoveScriptable : ScriptableObject
{
    [Header("Move Differentiator")]
    public string moveName;

    [Header("Move Attributes")]
    public float moveDamage;
    public float moveAccuracy;
    public int moveCost;
}

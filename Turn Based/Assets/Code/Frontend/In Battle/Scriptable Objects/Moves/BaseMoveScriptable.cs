using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/BaseMove")]
public class BaseMoveScriptable : ScriptableObject
{
    public string moveName;

    public float moveDamage;
    [Range(0,100)]
    public float moveAccuracy;
}

using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "ScriptableObjects/Moves/BaseMove")]
public class BaseMoveScriptable : ScriptableObject
{
    public string moveKey;

    public float moveDamage;
    [Range(0,100)]
    public float moveAccuracy;
}

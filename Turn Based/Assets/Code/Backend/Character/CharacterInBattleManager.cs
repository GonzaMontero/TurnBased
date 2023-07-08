using UnityEngine;

public class CharacterInBattleManager : MonoBehaviourSingleton<CharacterInBattleManager>
{
    public IngameCharacterManager playerStats;
    public EnemyScriptable enemyStats;

    private void Start()
    {
        playerStats = IngameCharacterManager.Get();
        //enemyStats = EnemyManager.Instance.enemyScriptable;
    }

}

using UnityEngine;

public class CharacterInBattleManager : MonoBehaviourSingleton<CharacterInBattleManager>
{
    public IngameCharacterManager playerStats;
    public EnemyInBattleManager enemyStats;

    private void Start()
    {
        playerStats = IngameCharacterManager.Get();
        enemyStats = EnemyInBattleManager.Get();
    }

}

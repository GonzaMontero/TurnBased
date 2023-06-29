using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSetup : MonoBehaviour
{
    public MoveButtonPrototype prototype;

    void Start()
    {
        var instance = CharacterInBattleManager.Get();

        for(short i = 0; i < CharacterStats.MOVELIMITCOUNT; i++)
        {
            var movePrototype = Instantiate(prototype);

            prototype.moveNameText.text = instance.playerStats.moves[i].moveName; 
        }
    }
}

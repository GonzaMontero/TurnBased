using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSetup : MonoBehaviour
{
    public MoveButtonPrototype prototype;
    public Transform attackButtonContainer;

    void Start()
    {
        var instance = CharacterInBattleManager.Get();

        for (short i = 0; i < instance.playerStats.moves.Count; i++)
        {
            if (instance.playerStats.moves[i] != null)
            {
                var movePrototype = Instantiate(prototype, attackButtonContainer);
                movePrototype.moveNameText.text = instance.playerStats.moves[i].moveName;

                if (instance.playerStats.moves[i] is SpecialMoveScriptable) {
                    movePrototype.activationButton.onClick.AddListener(() =>
                    {
                        Debug.Log("Used Special Move");
                    });
                }
                else if(instance.playerStats.moves[i] is PhysicalMoveScriptable)
                {
                    movePrototype.activationButton.onClick.AddListener(() =>
                    {
                        Debug.Log("Used Physical Move");
                    });
                }
                else
                {
                    Debug.Log("Move in slot " + i + " is not of allowed Types");
                }
            }
            else
            {
                Debug.LogError("Error loading player move in slot " + i + " verify move exists and is either special or physical move");
            }
        }

        prototype.gameObject.SetActive(false);
    }
}

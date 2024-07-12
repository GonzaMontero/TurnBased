using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AutomaticTextLocalizer : MonoBehaviour
{
    TextMeshProUGUI textField;

    public string key;
    
    private void Start()
    {
        textField = GetComponent<TextMeshProUGUI>();

        string s = Loc.ReplaceKey(key); 

        textField.text = s;

        CommandManager.Get().OnSettingsChanged.AddListener(
            () => textField.text = Loc.ReplaceKey(key)
            );
    }

    private void OnDestroy()
    {
        CommandManager.Get().OnSettingsChanged.RemoveListener(
            () => textField.text = Loc.ReplaceKey(key)
            );
    }
}

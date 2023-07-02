using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettingsManager : MonoBehaviourSingleton<PlayerSettingsManager>
{
    private void Start()
    {
        Loc.currentLanguage = (Loc.Language)PlayerPrefs.GetInt("language", 0);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("language", (int)Loc.currentLanguage);
        PlayerPrefs.Save();
    }
}

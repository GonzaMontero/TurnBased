using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsPanel : MonoBehaviour
{
    public TMP_Dropdown languageDropdown;
    public Slider volumeSlider;
    public Button backButton;

    private void Start()
    {
        SetupDropdown();
        SetupSlider();
        SetupButton();
    }

    #region LanguageDropdown
    private void SetupDropdown()
    {
        List<TMP_Dropdown.OptionData> languageList = new List<TMP_Dropdown.OptionData>();

        languageDropdown.ClearOptions();

        for (short i = 0; i < Enum.GetNames(typeof(Loc.Language)).Length; i++)
        {
            TMP_Dropdown.OptionData data = new TMP_Dropdown.OptionData();

            Loc.Language language = (Loc.Language)i;
            data.text = language.ToString();

            languageList.Add(data);
        }

        languageDropdown.AddOptions(languageList);
        languageDropdown.onValueChanged.AddListener(delegate
        {
            ChangeLanguage(languageDropdown);
            CommandManager.Get().OnSettingsChanged.Invoke();
        });

        languageDropdown.value = (int)Loc.currentLanguage;
    }

    void ChangeLanguage(TMP_Dropdown change)
    {
        Loc.currentLanguage = (Loc.Language)change.value;
    }
    #endregion

    #region VolumeSlider

    private void SetupSlider()
    {

    }

    #endregion

    #region BackButton

    private void SetupButton()
    {
        backButton.onClick.AddListener(() =>
        {
            MainMenuPanelsHolder.Get().mainMenuPanel.SetActive(true);
            MainMenuPanelsHolder.Get().settingsPanel.SetActive(false);
        });
    }

    #endregion
}

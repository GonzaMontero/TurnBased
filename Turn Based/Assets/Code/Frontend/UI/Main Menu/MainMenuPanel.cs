using UnityEngine;
using UnityEngine.UI;

public class MainMenuPanel : MonoBehaviour
{
    public Button playButton;
    public Button settingsButton;
    public Button savesButton;
    public Button exitButton;

    private void Start()
    {
        //playButton.onClick.AddListener(() =>
        //{
        //    MainMenuPanelsHolder.Get().settingsPanel.SetActive(true);
        //    MainMenuPanelsHolder.Get().mainMenuPanel.SetActive(false);
        //});

        settingsButton.onClick.AddListener(() =>
        {
            MainMenuPanelsHolder.Get().settingsPanel.SetActive(true);
            MainMenuPanelsHolder.Get().mainMenuPanel.SetActive(false);
        });

        //savesButton.onClick.AddListener(() =>
        //{
        //    MainMenuPanelsHolder.Get().settingsPanel.SetActive(true);
        //    MainMenuPanelsHolder.Get().mainMenuPanel.SetActive(false);
        //});

        exitButton.onClick.AddListener(() => Application.Quit());
    }
}

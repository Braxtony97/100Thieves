using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenuScreen : MainScreenUI
{
    [Header("Main Buttons")]
    [SerializeField] private Button _play;
    [SerializeField] private Button _store;
    [SerializeField] private Button _multiplayer;
    [SerializeField] private Button _settings;
    [SerializeField] private Button _exit;

    [Header("Control Buttons")]
    [SerializeField] private Button _back;

    public override void Setup()
    {
        base.Setup(); 

        SetListeners();
    }

    private void SetListeners()
    {
        _play.onClick.AddListener(LoadPlayMode);

        _store.onClick.AddListener(() =>
        {
            Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.StoreScreen.ToString());
        });

        _exit.onClick.AddListener(OnExitButtonClick);

        _back.onClick.AddListener(() =>
        {
            Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.LoadScreen.ToString());
        });
    }

    public void LoadPlayMode()
    {
        _sceneManager.LoadScene(Enums.Scene.PlayMode.ToString());


        //Master.Instance.LoadScene(Enums.Scene.PlayMode.ToString());
        Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.PlayModeScreen.ToString());
    }

    private void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

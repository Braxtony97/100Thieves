using UnityEngine;
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

    private void OnExitButtonClick()
    {
#if UNITY_EDITOR
        Debug.Log("Exit button clicked. Cannot exit playmode in the editor.");
#else
        Application.Quit();
#endif
    }
}

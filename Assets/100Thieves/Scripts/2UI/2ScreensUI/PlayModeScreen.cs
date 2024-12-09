using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayModeScreen : MainScreenUI
{
    [Header("Control Buttons")]
    [SerializeField] private Button _back;

    public override void Setup()
    {
        base.Setup();

        SetListeners();
    }

    private void SetListeners()
    {
        _back.onClick.AddListener(() =>
        {
            Master.Instance.LoadScene(Enums.Scene.MainScene.ToString());
            Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.MainMenu.ToString());
        });
    }
}

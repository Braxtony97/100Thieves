using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadScreen : MainScreenUI
{
    [SerializeField] private Button _mainMenuButton;

    public override void Setup()
    {
        base.Setup();

        SetListeners();
    }

    private void SetListeners()
    {
        _mainMenuButton.onClick.AddListener(() =>
        {
            Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.MainMenu.ToString());
        });
    }
}

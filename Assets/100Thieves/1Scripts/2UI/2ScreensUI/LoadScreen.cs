using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoadScreen : MainScreenUI
{
    [SerializeField] private Button _mainMenuButton;

    private void Start()
    {
        _mainMenuButton.onClick.AddListener(() =>
        {
            Master.Instance.ManagerUI.ShowScreen(Enums.ScreenView.MainMenu.ToString());
        });
    }
}

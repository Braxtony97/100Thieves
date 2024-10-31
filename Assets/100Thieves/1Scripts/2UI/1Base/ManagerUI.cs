using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerUI : MonoBehaviour
{
    private Dictionary<string, MainScreenUI> _screensUI = new Dictionary<string, MainScreenUI>();
    private MainScreenUI _currentScreenUI;

    public void Setup()
    {
        foreach (Transform child in transform)
        {
            MainScreenUI screen = child.GetComponent<MainScreenUI>();
            if (screen != null)
            {
                _screensUI.Add(screen.name, screen);
                screen.HideScreen();
                screen.Setup();
            }
        }

        ShowScreen(Enums.ScreenView.LoadScreen.ToString());
    }

    public void ShowScreen(string screenName)
    {
        if (_currentScreenUI != null)
        {
            _currentScreenUI.HideScreen();
        }

        if (_screensUI.TryGetValue(screenName, out MainScreenUI mainScreen))
        {
            mainScreen.ShowScreen();
            _currentScreenUI = mainScreen;
        }
        else
        {
            Debug.Log($"Screen {screenName} not found");
        }
    }
}

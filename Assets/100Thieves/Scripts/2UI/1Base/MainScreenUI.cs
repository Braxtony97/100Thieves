using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public abstract class MainScreenUI : MonoBehaviour, IScreenUI
{
    protected SceneManagerService _sceneManager;

    [Inject]
    public void Construct(SceneManagerService sceneManager)
    {
        Debug.Log("Inject");
        _sceneManager = sceneManager;
    }

    public virtual void Setup()
    {

    }

    public void ShowScreen()
    {
        gameObject.SetActive(true);
    }

    public void HideScreen()
    {
        gameObject.SetActive(false);
    }
}

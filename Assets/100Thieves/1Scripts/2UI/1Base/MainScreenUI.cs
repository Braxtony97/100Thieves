using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MainScreenUI : MonoBehaviour, IScreenUI
{
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

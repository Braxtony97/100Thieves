using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    [SerializeField] private ManagerUI _managerUI;

    void Start()
    {
        DontDestroyOnLoad(this);

        _managerUI.Setup();
    }
}

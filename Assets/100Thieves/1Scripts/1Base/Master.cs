using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public static Master Instance;
    public ManagerUI ManagerUI => _managerUI;

    [SerializeField] private ManagerUI _managerUI;

    void Start()
    {
        DontDestroyOnLoad(this);

        Instance = this;

        _managerUI.Setup();
    }
}

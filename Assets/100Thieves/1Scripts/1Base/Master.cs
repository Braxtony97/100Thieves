using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    [SerializeField] private Image _100thievesSticker;

    void Start()
    {
        DontDestroyOnLoad(this);
        _100thievesSticker.enabled = true;
    }
}

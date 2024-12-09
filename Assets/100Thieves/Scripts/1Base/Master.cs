using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public static Master Instance;
    public ManagerUI ManagerUI => _managerUI;

    [SerializeField] private ManagerUI _managerUI;

    void Awake()
    {
        if (Instance != null && Instance != this) // Temp -> need GameManager
        {
            Destroy(gameObject); 
            return;
        }

        DontDestroyOnLoad(this);

        Instance = this;
    }

    private void Start()
    {
        _managerUI.Setup();
    }

    public void LoadScene(string sceneName)
    {
        //SceneManager.LoadSceneAsync(sceneName);
    }
}

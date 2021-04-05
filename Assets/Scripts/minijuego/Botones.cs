using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script que regula el comportamiento de los botones de la GUI

public class Botones : MonoBehaviour
{
    public Button botonTryAgain;
    public Button botonMenu;

    void Start()
    {
        botonTryAgain.onClick.AddListener(delegate { TaskOnClick("TryAgain"); });
        botonMenu.onClick.AddListener(delegate { TaskOnClick("Menu"); });
    }

    void Update()
    {
        
    }

    void TaskOnClick(string objeto)
    {
        switch(objeto)
        {
            case "TryAgain":
                SceneManager.LoadScene("minijuego");
                break;
            case "Menu":
                SceneManager.LoadScene("Menu");
                break;
        }
    }
}

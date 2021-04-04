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
        botonTryAgain.onClick.AddListener(delegate { TaskOnClick(1); });
        botonMenu.onClick.AddListener(delegate { TaskOnClick(2); });
    }

    void Update()
    {
        
    }

    void TaskOnClick(int i)
    {
        switch(i)
        {
            case 1:
                SceneManager.LoadScene("minijuego");
                break;
            case 2:
                Debug.Log("Menu pulsado");
                break;
        }
    }
}

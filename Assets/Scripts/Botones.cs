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
        botonTryAgain.onClick.AddListener(delegate { TaskOnClick("Bola1"); });
        botonMenu.onClick.AddListener(delegate { TaskOnClick("Bola2"); });
    }

    void Update()
    {
        
    }

    void TaskOnClick(string objeto)
    {
        switch(objeto)
        {
            case "Bola1":
                SceneManager.LoadScene("minijuego");
                break;
            case "Bola2":
                Debug.Log("Menu pulsado");
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorBotones : MonoBehaviour
{
    public Button MapaButton;
    public Button CatalogoButton;
    public Button MinijuegoButton;
    // Start is called before the first frame update
    void Start()
    {
        MapaButton.onClick.AddListener(delegate { TaskOnClick("Mapa"); });
        CatalogoButton.onClick.AddListener(delegate { TaskOnClick("Catalogo"); });
        MinijuegoButton.onClick.AddListener(delegate { TaskOnClick("Minijuego"); });
    }

    void TaskOnClick(string boton)
    {
        switch (boton)
        {
            case "Mapa":
                // SceneManager.LoadScene("Mapa");
                break;
            case "Catalogo":
                // SceneManager.LoadScene("Catalogo");
                break;
            case "Minijuego":
                SceneManager.LoadScene("Minijuego");
                break;
        }
    }

       
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public Button botonTryAgain;
    public Button botonMenu;
    // Start is called before the first frame update
    void Start()
    {
        botonTryAgain.onClick.AddListener(delegate { TaskOnClick(1); });
        botonMenu.onClick.AddListener(delegate { TaskOnClick(2); });
    }

    // Update is called once per frame
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

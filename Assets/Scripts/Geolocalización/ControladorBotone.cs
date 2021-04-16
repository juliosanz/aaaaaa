using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControladorBotone : MonoBehaviour
{
    public Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        MenuButton.onClick.AddListener(delegate { TaskOnClick("Menu"); });
    }

    // Update is called once per frame
    void TaskOnClick(string boton)
    {
        switch (boton)
        {
            case "Menu": 
                SceneManager.LoadScene("Menu");
                break;
        }
    }
}

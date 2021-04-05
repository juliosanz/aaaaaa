using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BotonMenu : MonoBehaviour
{
    public Button MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        MenuButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMeta : MonoBehaviour
{
    public GameObject bola1;
    public GameObject bola2;
    public GameObject texto;
    public GameObject tryAgainButton;
    private MovimientoBolas bola1script;
    private MovimientoBolas bola2script;
    // Start is called before the first frame update
    void Start()
    {
        bola1script = bola1.GetComponent<MovimientoBolas>();
        bola2script = bola2.GetComponent<MovimientoBolas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!bola1script.enabled && !bola2script.enabled)
        {
            texto.SetActive(true);
            tryAgainButton.SetActive(true);
        }
    }
}

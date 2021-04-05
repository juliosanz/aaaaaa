using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script que detecta cuándo ambas bolas han llegado a su destino, y hace la GUI de victoria visible en ese caso

public class ControladorMeta : MonoBehaviour
{
    public GameObject bola1;
    public GameObject bola2;
    public GameObject texto;
    public GameObject tryAgainButton;
    private Rigidbody bola1Rigidbody;
    private Rigidbody bola2Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        bola1Rigidbody = bola1.GetComponent<Rigidbody>();
        bola2Rigidbody = bola2.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bola1Rigidbody.isKinematic && bola2Rigidbody.isKinematic)
        {
            texto.SetActive(true);
            tryAgainButton.SetActive(true);
        }
    }
}

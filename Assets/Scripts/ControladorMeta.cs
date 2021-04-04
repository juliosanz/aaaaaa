using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMeta : MonoBehaviour
{
    public GameObject bola1;
    public GameObject bola2;
    public GameObject texto;
    public GameObject tryAgainButton;
    private MovimientoBolas bola1movimiento;
    private MovimientoBolas bola2movimiento;
    // Start is called before the first frame update
    void Start()
    {
        bola1movimiento = bola1.GetComponent<MovimientoBolas>();
        bola2movimiento = bola2.GetComponent<MovimientoBolas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!bola1movimiento.enabled && !bola2movimiento.enabled)
        {
            texto.SetActive(true);
            tryAgainButton.SetActive(true);
        }
    }
}

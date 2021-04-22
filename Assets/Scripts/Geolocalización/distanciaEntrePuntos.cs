using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanciaEntrePuntos : MonoBehaviour
{
    public GameObject destino;
    private float distancia;
    public Text debugger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector3.Distance(transform.position, destino.transform.position) * 111100;
        Debug.Log(distancia);
        debugger.text = distancia.ToString();
    }
}

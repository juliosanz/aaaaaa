using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconoCreciente : MonoBehaviour
{
    public GameObject persona;
    public GameObject destino;
    private float distancia;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        // latitudP = Input.location.lastData.latitude;
        // altitudP = Input.location.lastData.altitude;
        Vector3 pPersona = persona.transform.position;
        Vector3 pDestino = destino.transform.position;
        distancia = Vector3.Distance(pPersona, pDestino);
    }
}

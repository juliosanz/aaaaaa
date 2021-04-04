using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script del GameObject "metax" que comprueba si la bola correcta ha llegado a su correspondiente meta,
// y cambia el material tanto de la meta como de la bola para mostrar visualmente que se ha llegado

public class Meta : MonoBehaviour
{
    private int numMeta;
    public Material successMaterial;

    void Start()
    {
        if(name.EndsWith("1"))
        {
            numMeta = 1;
        }
        else
        {
            numMeta = 2;
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bola" + numMeta)
        {
            other.gameObject.GetComponent<MovimientoBolas>().enabled = false;
            GetComponent<MeshRenderer>().material = successMaterial;
            other.gameObject.GetComponent<MeshRenderer>().material = successMaterial;
        }
    }
}

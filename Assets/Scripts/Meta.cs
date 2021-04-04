using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    private string nameMeta;
    private int numMeta;
    public Material successMaterial;
    // Start is called before the first frame update
    void Start()
    {
        nameMeta = name;
        if(name.EndsWith("1"))
        {
            numMeta = 1;
        }
        else
        {
            numMeta = 2;
        }
    }

    // Update is called once per frame
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarCamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Input.location.lastData.longitude, 0, Input.location.lastData.latitude);
        Debug.Log("Longitud: " + Input.location.lastData.longitude + "\tLatitud: " + Input.location.lastData.latitude);
        Debug.Log(transform.localPosition);
    }
}

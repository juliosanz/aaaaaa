using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSuelo : MonoBehaviour
{
    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.deviceOrientation.Equals(DeviceOrientation.FaceUp))
        {
            Vector3 movimiento = new Vector3(Input.acceleration.x, 0f, Input.acceleration.y);
            transform.Translate(movimiento * velocidad * Time.deltaTime);
        }
    }
}

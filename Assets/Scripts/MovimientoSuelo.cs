using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSuelo : MonoBehaviour
{
    private Rigidbody cuerpoBola;
    public float velocidad = 10f;
    // Start is called before the first frame update
    void Start()
    {
        cuerpoBola = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.deviceOrientation.Equals(DeviceOrientation.FaceUp))
        {
            Vector3 movimiento = new Vector3(Input.acceleration.x, 0f, Input.acceleration.y);
            cuerpoBola.AddForce(movimiento, ForceMode.Acceleration);
        }
    }
}

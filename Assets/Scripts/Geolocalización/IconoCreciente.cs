using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconoCreciente : MonoBehaviour
{
    private float latitudP;
    private float altitudP;
    
    // Start is called before the first frame update
    void Start()
    {
        latitudP = Input.location.lastData.latitude;
        altitudP = Input.location.lastData.altitude;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        latitudP = Input.location.lastData.latitude;
        altitudP = Input.location.lastData.altitude;
    }
}

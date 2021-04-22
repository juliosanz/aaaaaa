using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movimientoFlecha : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objetivo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //apunta hacie el objetivo
        //float catetoA = objetivo.transform.position.x - Input.location.lastData.longitude;
        //float catetoB = objetivo.transform.position.z - Input.location.lastData.latitude;

        transform.LookAt(new Vector3(objetivo.transform.position.x, transform.position.y, objetivo.transform.position.z));
    }

}

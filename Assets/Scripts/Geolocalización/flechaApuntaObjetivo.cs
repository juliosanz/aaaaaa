using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class flechaApuntaObjetivo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objetivo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3(objetivo.transform.position.x, transform.position.y, objetivo.transform.position.z));
    }

}

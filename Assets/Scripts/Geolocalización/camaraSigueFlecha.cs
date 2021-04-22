using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraSigueFlecha : MonoBehaviour
{
    public GameObject flecha;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(-0.26f, 0.231f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = flecha.transform.position + offset;
    }
}

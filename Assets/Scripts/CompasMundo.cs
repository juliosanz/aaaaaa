using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompasMundo : MonoBehaviour
{
    public GameObject mundo;
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        GyroModifyCamera();
        mundo.transform.rotation = Quaternion.Euler(0, int(-Input.compass.trueHeading), 0);
    }

    // The Gyroscope is right-handed.  Unity is left handed.
    // Make the necessary change to the camera.
    void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}

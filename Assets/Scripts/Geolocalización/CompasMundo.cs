using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompasMundo : MonoBehaviour
{
    void Start()
    {
        Input.location.Start();
        transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        GyroModifyCamera();
    }

    // The Gyroscope is right-handed.  Unity is left handed.
    // Make the necessary change to the camera.
    void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        q.y = 0;
        q.w = 0;
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}

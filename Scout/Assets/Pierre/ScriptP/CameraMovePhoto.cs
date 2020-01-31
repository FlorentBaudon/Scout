using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovePhoto : MonoBehaviour
{
    public float speedY,speedX;
    public float yaw, pitch;
    public float yawMin, yawMax;
    public float pitchMin, pitchMax;

    // Update is called once per frame
    void Update()
    {
        yaw += speedY * Input.GetAxis("Mouse Y");
        pitch += speedX * Input.GetAxis("Mouse X");

        if (yaw< yawMin)
        {
            yaw = yawMin;
        }

        if (yaw > yawMax)
        {
            yaw = yawMax;
        }

        if (pitch < pitchMin)
        {
            pitch = pitchMin;
        }

        if (pitch > pitchMax)
        {
            pitch = pitchMax;
        }

        transform.eulerAngles = new Vector3(yaw, pitch, 0.0f);
    }
}

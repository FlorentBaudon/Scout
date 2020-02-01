using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovePhoto : MonoBehaviour
{
    public float speedY,speedX, speedZoom;
    public float yaw, pitch, zoom;
    public float yawMin, yawMax;
    public float pitchMin, pitchMax;
    public float zoomMin, zoomMax;

    float camerazoom = 60;

    public Camera myCamera;

    public void Awake()
    {
        myCamera=GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButton(1))
        {
            pitch += speedX * Input.GetAxis("Mouse X");
            yaw -= speedY * Input.GetAxis("Mouse Y");
        }
        zoom += speedZoom * Input.GetAxis("Mouse ScrollWheel");

        if (yaw< yawMin)
        {
            yaw = yawMin;
        }

        if (yaw > yawMax)
        {
            yaw = yawMax;
        }

        /*if (pitch < pitchMin)
        {
            pitch = pitchMin;
        }

        if (pitch > pitchMax)
        {
            pitch = pitchMax;
        }*/

        transform.eulerAngles = new Vector3(yaw, pitch, 0.0f);

        float cameraZoomdifference = myCamera.fieldOfView - (camerazoom-zoom);
        myCamera.fieldOfView-=cameraZoomdifference*Time.deltaTime;

        if (myCamera.fieldOfView < camerazoom+zoomMin)
        {
            myCamera.fieldOfView = camerazoom + zoomMin;
            zoom = -zoomMin;
        }

        if (myCamera.fieldOfView > camerazoom + zoomMax)
        {
            myCamera.fieldOfView = camerazoom + zoomMax;
            zoom = -zoomMax;
        }
    }
}

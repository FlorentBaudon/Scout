using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectifCapture : MonoBehaviour
{
    public float scoreGiven;
    public float Fieldstandardview = 60;
    public float distanceVector = 30;

    public void Awake()
    {

    }

    public void Update()
    {
        if (TakeScreenShot.instance.isTakingScreenShot)
        {
            Vector3 positionVector = TakeScreenShot.instance.GetComponent<Camera>().WorldToViewportPoint(transform.position);

            if (positionVector.x < .9f && positionVector.x > 0.1f && positionVector.y < .9f && positionVector.y > 0.1f && positionVector.z < 30)
            {
                Debug.Log("score won : "+ (scoreGiven * (30 - positionVector.z)*60/Camera.main.fieldOfView));
                TakeScreenShot.instance.ScoreCapture=scoreGiven*30-positionVector.z;
            }
        }
    }
    
}

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectifCapture : MonoBehaviour
{
    public string partiCapturer;

    public float scoreGiven;
    public float Fieldstandardview = 60;
    public float distanceVector = 30;

    public void Update()
    {
        if (TakeScreenShot.instance.isTakingScreenShot)
        {
            Vector3 positionVector = TakeScreenShot.instance.GetComponent<Camera>().WorldToViewportPoint(transform.position);

            if (positionVector.x < .9f && positionVector.x > 0.1f && positionVector.y < .9f && positionVector.y > 0.1f && positionVector.z < 30)
            {
                bool isInlist=false;
                foreach (string animaltaken in TakeScreenShot.instance.animalTaken)
                {
                    if (partiCapturer== animaltaken)
                    {
                        isInlist = true;
                    }
                }
                if (isInlist)
                {
                    TakeScreenShot.instance.ScoreCapture = scoreGiven * (30 - positionVector.z) * (Camera.main.fieldOfView / 60) / 3;
                }
                else
                {
                    TakeScreenShot.instance.ScoreCapture = scoreGiven * (30 - positionVector.z) * (Camera.main.fieldOfView / 60);
                    TakeScreenShot.instance.animalTaken.Add(partiCapturer);
                }
                
            }
        }
    }
    
}

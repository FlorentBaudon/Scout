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

    public void Start()
    {
        TakeScreenShot.instance.AnimalInGame.Add(this);
    }

    public float isInShot()
    {
        Vector3 positionVector = TakeScreenShot.instance.GetComponent<Camera>().WorldToViewportPoint(transform.position);
        
        if (positionVector.x < .9f && positionVector.x > 0.1f && positionVector.y < .9f && positionVector.y > 0.1f && positionVector.z < 30 && positionVector.z > 0)
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
                return scoreGiven * (30 - positionVector.z) * (Camera.main.fieldOfView / 60) / 3;
            }
            else
            {
                TakeScreenShot.instance.animalTaken.Add(partiCapturer);
                return scoreGiven * (30 - positionVector.z) * (Camera.main.fieldOfView / 60);
            }
        }
        else
        {
            return 0;
        }
    }
    
}

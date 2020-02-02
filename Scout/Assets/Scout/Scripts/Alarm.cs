using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();

        GameObject[] prods = GameObject.FindGameObjectsWithTag("a_reparer");
        foreach(GameObject go in prods)
        {
            go.GetComponent<Prod>().breakEvent.AddListener(setAlarm);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setAlarm(bool b)
    {
        GameObject[] prods = GameObject.FindGameObjectsWithTag("a_reparer");
        if (b)
        {
            if(!audio.isPlaying)
                audio.Play();

            setLight(Color.red);
        }
        else
        {
            var isRepair = false;
            foreach (GameObject go in prods)
            {
                if (go.GetComponent<Prod>().isBroken)
                    isRepair = true;
            }
            if (!isRepair)
            {
                audio.Stop();
                setLight(Color.white);
            }
        }
    }

    public void setLight(Color c)
    {
        GameObject[] lights = GameObject.FindGameObjectsWithTag("AlarmLight");
        foreach(GameObject l in lights)
        {
            l.GetComponent<Light>().color = c;
        }
    }
}

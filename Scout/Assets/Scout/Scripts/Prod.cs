using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoolEvent : UnityEvent<bool>
{
}

public class Prod : MonoBehaviour
{
    public Storage storage;
    [HideInInspector]
    public float amountRate = 0;
    [HideInInspector]
    public float powerConsumption = 0; //set to 0 for power production
    public bool isBroken = false;
    public ParticleSystem[] particles;

    public BoolEvent breakEvent = new BoolEvent();

    public void addToStorage()
    {
        if (!this.isBroken)
        {
            this.storage.addToStorage(this.amountRate);
        }
    }

    public void breakProd ()
    {
        this.isBroken = true;
        breakEvent.Invoke(true);
        foreach(ParticleSystem ps in particles)
        {
            ps.Play();
        }
    }

    public void repairProd ()
    {
        this.isBroken = false;
        breakEvent.Invoke(false);
        foreach (ParticleSystem ps in particles)
        {
            ps.Stop();
        }
    }

    private void Update()
    {
        addToStorage();
    }
}

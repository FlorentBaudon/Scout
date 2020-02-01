﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prod : MonoBehaviour
{
    public Storage storage;
    public float amountRate = 10;
    public bool isBroken = false;
    public ParticleSystem particle;


    public void addToStorage()
    {
        if (!this.isBroken)
        {
            this.storage.addToStorage(this.amountRate * Time.deltaTime);
        }
    }

    public void breakProd ()
    {
        Debug.Log("break");
        this.isBroken = true;
        if (particle)
        {
            particle.Play();
        }
    }

    public void repairProd ()
    {
        this.isBroken = false;
        if (particle)
        {
            particle.Stop();
        }
    }

    private void Update()
    {
        addToStorage();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public float amount = 100;
    private Gauge gauge;

    private void Start()
    {
        gauge = GetComponent<Gauge>();
    }

    public void addToStorage (float amountRate)
    {
        this.amount += amountRate;
        this.amount = Mathf.Clamp(this.amount, 0, 100);
        gauge.setValue(this.amount);
    }

    public float getAmount()
    {
        return this.amount;
    }

    public float getFromStorage(float amountRate)
    {
        this.amount -= amountRate;
        return amountRate;
    }
}

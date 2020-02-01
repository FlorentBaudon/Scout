using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField]
    float amount = 100;
    private Gauge gauge;

    private void Start()
    {
        gauge = GetComponent<Gauge>();
    }

    public void addToStorage (float amountRate)
    {
        this.amount += amountRate * Time.deltaTime;
        this.amount = Mathf.Clamp(this.amount, 0, 100);
        gauge.setValue(this.amount);
    }

    public float getAmount()
    {
        return this.amount;
    }

    public void getFromStorage(float amountRate)
    {
        Debug.Log(this.amount + " - " + amountRate);
        this.amount -= amountRate * Time.deltaTime;
        this.amount = Mathf.Clamp(this.amount, 0, 100);
        gauge.setValue(this.amount);
    }
}

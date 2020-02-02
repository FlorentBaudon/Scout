using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class floatEvent : UnityEvent<float>
{
}

public class ShipManager : MonoBehaviour
{
    public Prod powerProd;
    public Prod waterProd;
    public Prod airProd;

    public float waterPowerConsumption = 5;
    public float airPowerConsumption = 5;

    float totalPowerConsumption = 0;

    public float airConsumption = 1;

    public float waterProdAmount = 1;
    public float airProdAmount = 2;

    public floatEvent powerEvent = new floatEvent();
    public floatEvent airEvent = new floatEvent();

    float timeElapsed = 0;
    public float timeTriggerRandom = 3;

    List<Prod> producerList;

    private void Start()
    {
        waterProd.powerConsumption = waterPowerConsumption;
        airProd.powerConsumption = airPowerConsumption;

        totalPowerConsumption += waterPowerConsumption;
        totalPowerConsumption += airPowerConsumption;

        powerProd.amountRate = totalPowerConsumption * 1.5f;
        waterProd.amountRate = waterProdAmount;
        airProd.amountRate = airProdAmount;

        producerList = new List<Prod> { powerProd, waterProd, airProd };
    }

    private void Update()
    {
        powerProd.storage.getFromStorage(totalPowerConsumption);
        airProd.storage.getFromStorage(airConsumption);
        //generateEvent();
        powerEvent.Invoke(powerProd.storage.getAmount());
        airEvent.Invoke(airProd.storage.getAmount());

        testProd();


    }

    void generateEvent()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeTriggerRandom)
        {
            timeElapsed = 0;
            int randomBreak = Random.Range(0, 10) % 3;
            if (randomBreak == 0)
            {
                int randomProd = Random.Range(0, producerList.Count);
                Prod p = producerList[randomProd];
                if (!p.isBroken)
                {
                    p.breakProd();
                    Debug.Log(p);
                }
            }
        }
    }

    void testProd ()
    {
        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            powerProd.breakProd();
        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            powerProd.repairProd();
        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            waterProd.breakProd();
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            waterProd.repairProd();
        }

        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            airProd.breakProd();
        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            airProd.repairProd();
        }
    }
}

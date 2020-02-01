using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    public Prod powerProd;
    public Prod waterProd;
    public Prod airProd;

    private void Update()
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

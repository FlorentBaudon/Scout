using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gauge : MonoBehaviour
{
    Slider slider;
    public Image image;
    public Text valueText;
    float value = 0;

    private void Start()
    {
        ShipManager shipManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ShipManager>();

        slider = this.GetComponent<Slider>();
    }

    public void setValue(float value)
    {
        this.value = value;
        slider.value = this.value/100;
        if (valueText)
        {
            valueText.text = Math.Truncate(value) + " %";
        }
    }

    void breakIndicator(bool b)
    {
        if (b)
        {
            image.color = Color.red;
        }else
        {
            image.color = Color.green;
        }
    }
}

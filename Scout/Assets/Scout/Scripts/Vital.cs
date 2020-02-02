using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vital : MonoBehaviour
{
    ShipManager shipManager;
    float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        shipManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<ShipManager>();
        shipManager.airEvent.AddListener(oxygenLevel);
    }

    void oxygenLevel(float airAmount)
    {
        if(airAmount == 0)
        {
            health -= (5.0f * Time.deltaTime);
        }

        if(health == 0)
        {
            shipManager.GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

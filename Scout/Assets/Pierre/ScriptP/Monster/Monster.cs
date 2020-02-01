using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    MonsterTurnAround patternMoving;

    public GameObject pivotMonster;

    public float speedMove, distanceObjectif;

    public void Start()
    {
        patternMoving.Appear(this);
        Invoke("killYourself", 8);
    }

    // Update is called once per frame
    void Update()
    {
        patternMoving.Move(this);
    }

    void killYourself()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    IMonsterMove patternMoving;

    public GameObject pivotMonster;

    public float speedMove, distanceObjectif;

    public string patternToChoose;

    public void Start()
    {
        switch (patternToChoose)
        {
            case ("turn"):
                patternMoving = MonsterMoveBase.MONSTER_TURNAROUND;
                break;
            case ("ignore"):
                patternMoving = MonsterMoveBase.MONSTER_IGNORE;
                break;
            default:
                patternMoving = MonsterMoveBase.MONSTER_IGNORE;
                break;
        }


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

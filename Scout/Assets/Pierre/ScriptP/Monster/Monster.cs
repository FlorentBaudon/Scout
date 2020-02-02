using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    IMonsterMove patternMoving;

    public Vector3 pivotMonster;

    public float speedMove, distanceObjectif;

    public string patternToChoose;

    public string AnimalName;

    public float timeToDie=15;

    public ObjectifCapture[] objectifsPhoto;

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
        Invoke("killYourself", 15);
    }

    // Update is called once per frame
    void Update()
    {
        patternMoving.Move(this);
    }

    void killYourself()
    {
        foreach (ObjectifCapture point in objectifsPhoto)
        {
            TakeScreenShot.instance.AnimalInGame.Remove(point);
        }
        Destroy(gameObject);
    }
}

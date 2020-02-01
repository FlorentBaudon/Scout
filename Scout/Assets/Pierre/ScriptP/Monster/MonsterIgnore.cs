using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIgnore : MonsterMoveBase
{
    public override void Move(Monster monster)
    {
        monster.transform.Translate(Time.deltaTime*monster.speedMove*-Vector3.right);
    }

    public override void Appear(Monster monster)
    {
        monster.transform.rotation= Quaternion.Euler(Random.Range(-15, 15),180+Random.Range(-15,15), Random.Range(-15, 15));
    }
}

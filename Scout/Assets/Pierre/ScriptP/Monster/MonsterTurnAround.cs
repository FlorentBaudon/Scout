using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTurnAround : MonsterMoveBase
{
    public override void Appear(Monster monster)
    {
        monster.pivotMonster = TakeScreenShot.instance.gameObject.transform.position;
    }
    public override void Move(Monster monster)
    {
        monster.transform.LookAt(monster.pivotMonster);
        monster.transform.Translate(new Vector3(1,Random.Range(0.1f,-0.1f), Random.Range(0, -1f)) * Time.deltaTime * monster.speedMove);
    }
}

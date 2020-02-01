using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTurnAround : MonsterMoveBase
{
    public override void Appear(Monster monster)
    {
        monster.transform.Translate(monster.transform.right * Time.deltaTime * monster.speedMove);
    }
    public override void Move(Monster monster)
    {
        monster.transform.LookAt(monster.pivotMonster.transform);
        monster.transform.Translate(monster.transform.right * Time.deltaTime * monster.speedMove);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIgnore : MonsterMoveBase
{
    public override void Move(Monster monster)
    {
        monster.transform.Translate(Time.deltaTime*monster.speedMove*monster.pivotMonster,Space.World);
    }

    public override void Appear(Monster monster)
    {
        monster.pivotMonster = monster.transform.forward;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonsterMoveBase : IMonsterMove
{

    public static readonly IMonsterMove MONSTER_IGNORE = new MonsterIgnore();
    public static readonly IMonsterMove MONSTER_TURNAROUND = new MonsterTurnAround();

    public virtual void Appear(Monster monster) { }
    public virtual void Move(Monster monster) { }
}

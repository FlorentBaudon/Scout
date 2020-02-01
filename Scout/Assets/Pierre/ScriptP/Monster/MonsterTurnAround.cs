using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTurnAround : MonoBehaviour
{
    public void Move(Monster monster)
    {
        monster.transform.Translate(Time.deltaTime*monster.speedMove*-Vector3.forward);
    }

    public void Appear(Monster monster)
    {

    }
}

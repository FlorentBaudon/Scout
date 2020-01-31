using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject MonsterToSpawn;

    public float ApparitionMin=4, ApparitionMax=8;

    public float sphereSize;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }

    public void Spawn()
    {
        Instantiate(MonsterToSpawn, ((Random.insideUnitSphere)+transform.position)*sphereSize,Quaternion.identity);
        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }
}

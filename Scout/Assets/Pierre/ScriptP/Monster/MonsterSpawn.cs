using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject[] MonsterToSpawn;

    public float ApparitionMin=4, ApparitionMax=8;

    public float sphereSize;

    public Transform[] spawnSphere;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }

    public void Spawn()
    {
        Vector3 rotation = new Vector3(Random.Range(-15, 15),  Random.Range(-15, 15), Random.Range(-15, 15));

        GameObject SpawnMonster = Instantiate(MonsterToSpawn[Random.Range(0, MonsterToSpawn.Length)], (spawnSphere[Random.Range(0,spawnSphere.Length-1)].position), Quaternion.Euler(rotation));

        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }
}

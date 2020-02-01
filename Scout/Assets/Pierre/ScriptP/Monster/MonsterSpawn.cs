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
        Instantiate(MonsterToSpawn[Random.Range(0, MonsterToSpawn.Length-1)], (/*(Random.insideUnitSphere*sphereSize)+*/spawnSphere[Random.Range(0,spawnSphere.Length)-1].position),Quaternion.identity);

        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }
}

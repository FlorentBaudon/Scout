using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnClass
    {
        public GameObject MonsterToSpawn;
        public Transform[] spawnSphere;
        public Vector3 rEuler;
    }

    public SpawnClass[] bestiaire;

    public float ApparitionMin=4, ApparitionMax=8;

    public float sphereSize;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }

    public void Spawn()
    {
        SpawnClass SpawnMonster = bestiaire[Random.Range(0, bestiaire.Length)];

        Vector3 rotation = new Vector3(SpawnMonster.rEuler.x + Random.Range(-15, 15), SpawnMonster.rEuler.y +Random.Range(-15, 15), SpawnMonster.rEuler.z+ Random.Range(-15, 15));

        Instantiate(SpawnMonster.MonsterToSpawn, (SpawnMonster.spawnSphere[Random.Range(0, SpawnMonster.spawnSphere.Length-1)].position), Quaternion.Euler(rotation));

        Invoke("Spawn", Random.Range(ApparitionMin, ApparitionMax));
    }
}

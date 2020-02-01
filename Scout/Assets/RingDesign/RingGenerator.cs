using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring
{
    public GameObject ring;
    public Vector3 rotationAxis;
    public float rotationSpeed;
}

public class RingGenerator : MonoBehaviour
{
    public GameObject RingPrefab;
    public float scaleFactor = 0.3f;
    public float speedFactor = 1;
    public float ringScaleOffset = 0.05f;
    public int NbRing=5;
    List<Ring> listRing;

    // Start is called before the first frame update
    void Start()
    {
        listRing = new List<Ring>();
        
        for (int i = 0; i < NbRing; i++)
        {
            GameObject o = Instantiate(RingPrefab);
            o.transform.localScale = Vector3.one * (scaleFactor - (ringScaleOffset*i));
            o.transform.rotation = Random.rotation;
            o.transform.parent = transform;
            o.transform.localPosition = Vector3.zero;
            Ring r = new Ring();
            r.ring = o;
            r.rotationAxis = Random.insideUnitSphere;
            r.rotationSpeed = Random.Range(-2f,2f);
            r.rotationSpeed *= speedFactor;
            listRing.Add(r);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var r in listRing)
        {
            
            r.ring.transform.Rotate(r.rotationAxis,r.rotationSpeed * speedFactor);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TeleporterTrigger : MonoBehaviour
{
    public Transform target;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            GameObject perso = other.gameObject;
            CharacterController cc = perso.GetComponent<CharacterController>();

            cc.enabled = false;
            perso.transform.position = target.position;
            cc.enabled = true;
        }
    }
}

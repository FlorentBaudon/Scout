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
            //perso.transform.Rotate(new Vector3(0, 180, 0), Space.Self); //TODO : Réparer ça, quand on se téléporte, il faut se retourner
            cc.enabled = true;
        }
    }
}

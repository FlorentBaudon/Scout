using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject character;
    public GameObject viewCamera;
    public float speedWalk;
    public float speedView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speedWalk;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speedWalk;

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * speedView;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * speedView;

        if (Input.GetAxis("Horizontal") != 0)
        {
            character.transform.Translate(horizontal, 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            character.transform.Translate(0, 0, vertical);
        }

        if(Input.GetAxis("Mouse X") != 0)
        {
            viewCamera.transform.Rotate(0, mouseX, 0, Space.Self);
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            viewCamera.transform.Rotate(-mouseY, 0, 0, Space.Self);
        }
    }
}

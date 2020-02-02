using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumManager : MonoBehaviour
{
    public GameObject panel;

    public RawImage[] rawImageCollection;
    public Text[] TextScore;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (panel.activeSelf)
            {
                panel.SetActive(false);
            }
            else
            {
                panel.SetActive(true);
            }
        }    }
}

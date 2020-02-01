using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumManager : MonoBehaviour
{
    public void ImportImage()
    {
        var sprite = Resources.Load < Sprite >("photoMonster");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlbumManager : MonoBehaviour
{
    public Image photo;

    public void ImportImage()
    {
        Sprite sprite = Resources.Load < Sprite >("photoMonster"+0+".png");

        photo.sprite = sprite;
    }
}

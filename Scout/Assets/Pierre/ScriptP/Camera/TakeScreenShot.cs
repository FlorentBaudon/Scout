using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenShot : MonoBehaviour
{
    public static TakeScreenShot instance;

    public float ScoreCapture;

    private Camera myCamera;
    public bool isTakingScreenShot;
    private int numberPhoto;

    public AlbumManager album;

    public List<string> animalTaken = new List<string>();

    public int[] pointPhotoTaken;

    public List<ObjectifCapture> AnimalInGame = new List<ObjectifCapture>();

    private void Awake()
    {
        instance = this;
        myCamera = GetComponent<Camera>();
    }

    private void OnPostRender()
    {
        if (isTakingScreenShot)
        {
            isTakingScreenShot = false;

            RenderTexture renderTexture = myCamera.targetTexture;

            Texture2D renderResult = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);

            Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
            renderResult.ReadPixels(rect, 0, 0);
            renderResult.Apply();


            byte[] byteArray = renderResult.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/Resources/photoMonster" + numberPhoto + ".png", byteArray);

            if (numberPhoto>= pointPhotoTaken.Length)
            {
                numberPhoto = 0;
                pointPhotoTaken[numberPhoto] = 0;
            }

            album.rawImageCollection[numberPhoto].texture = renderResult as Texture;

            RenderTexture.ReleaseTemporary(renderTexture);
            myCamera.targetTexture = null;

            pointPhotoTaken[numberPhoto] = 0;
            foreach (ObjectifCapture objectif in AnimalInGame)
            {
                if (objectif != null)
                {
                    Debug.Log(objectif.isInShot());
                    pointPhotoTaken[numberPhoto] += Mathf.FloorToInt(objectif.isInShot());
                }
            }
            album.TextScore[numberPhoto].text = ""+pointPhotoTaken[numberPhoto];
            numberPhoto++;
        }
    }

    public void TakePhoto(int height, int width, int depthbuffer)
    {
        myCamera.targetTexture = RenderTexture.GetTemporary(width, height, depthbuffer);
        isTakingScreenShot = true;
    }

    public void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            TakePhoto(myCamera.pixelHeight, myCamera.pixelHeight, 16);
        }
    }
}

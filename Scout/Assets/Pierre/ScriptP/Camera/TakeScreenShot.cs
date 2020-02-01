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

            byte[] byteArray = renderResult.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/Pierre/ScreenShot/photoMonster" + numberPhoto + ".png", byteArray);
            numberPhoto++;
            Debug.Log("Saved camera png");

            RenderTexture.ReleaseTemporary(renderTexture);
            myCamera.targetTexture = null;
        }
    }

    public void TakePhoto(int height, int width, int depthbuffer)
    {


        myCamera.targetTexture = RenderTexture.GetTemporary(width, height, depthbuffer);
        isTakingScreenShot = true;
    }

    public void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            TakePhoto(myCamera.pixelHeight, myCamera.pixelHeight, 16);
        }
    }
}

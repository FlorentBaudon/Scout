﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void QuitterApplication()
    {
        Application.Quit();
    }

    public void JouerAuJeu()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void RevenirMenuPrincipal()
    {
        Debug.Log("ALLLOOOOOO ???");
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }
}
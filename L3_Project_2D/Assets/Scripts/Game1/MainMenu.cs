﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        Debug.Log("NEXT!");
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }



}

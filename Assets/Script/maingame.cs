﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maingame : MonoBehaviour
{
    public void GoBack()
    {
        Application.LoadLevel("MenuUtama");
    }

    // Update is called once per frame
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Application.Quit();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public void GoMain()
    {
        Application.LoadLevel("alif");
    }

    public void GoAbout()
    {
        Application.LoadLevel("AboutUs");
    }

    public void GoHow()
    {
        Application.LoadLevel("CaraBermain");
    }

    public void Exit()
    {
        Application.Quit();
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

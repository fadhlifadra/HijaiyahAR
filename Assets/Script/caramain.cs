using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caramain : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoBack()
    {
        Application.LoadLevel("MenuUtama");
    }

    public void DownloadMarker()
    {
        Application.OpenURL("https://drive.google.com/open?id=1mOlcAHUfbcgVtColme4MMXFb09Yx2Cme");
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
                Application.LoadLevel("MenuUtama");
            }
        }
    }
}
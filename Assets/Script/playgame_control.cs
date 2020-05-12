using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playgame_control : MonoBehaviour
{
    public void GoBack()
    {
        Application.LoadLevel("MenuUtama");
    }

    public void Alif()
    {
        Application.LoadLevel("alif");
    }

    public void Ba()
    {
        Application.LoadLevel("ba");
    }

    public void Ta()
    {
        Application.LoadLevel("ta");
    }

    public void Tsa()
    {
        Application.LoadLevel("tsa");
    }

    public void Jim()
    {
        Application.LoadLevel("jim");
    }

    public void Kha()
    {
        Application.LoadLevel("kha");
    }

    public void Kho()
    {
        Application.LoadLevel("kho");
    }

    public void Dal()
    {
        Application.LoadLevel("dal");
    }

    public void Dzal()
    {
        Application.LoadLevel("dzal");
    }

    public void Ra()
    {
        Application.LoadLevel("ra");
    }

    public void Za()
    {
        Application.LoadLevel("za");
    }

    public void Sin()
    {
        Application.LoadLevel("sin");
    }

    public void Syin()
    {
        Application.LoadLevel("syin");
    }

    public void Shad()
    {
        Application.LoadLevel("shad");
    }

    public void Dhad()
    {
        Application.LoadLevel("dhad");
    }

    public void Tha()
    {
        Application.LoadLevel("tha");
    }

    public void Dha()
    {
        Application.LoadLevel("dha");
    }

    public void Ain()
    {
        Application.LoadLevel("ain");
    }

    public void Ghain()
    {
        Application.LoadLevel("ghain");
    }

    public void Fa()
    {
        Application.LoadLevel("fa");
    }

    public void Qaf()
    {
        Application.LoadLevel("qaf");
    }

    public void Kaf()
    {
        Application.LoadLevel("kaf");
    }

    public void Lam()
    {
        Application.LoadLevel("lam");
    }

    public void Mim()
    {
        Application.LoadLevel("mim");
    }

    public void Nun()
    {
        Application.LoadLevel("nun");
    }

    public void Wau()
    {
        Application.LoadLevel("wau");
    }

    public void Hamzah()
    {
        Application.LoadLevel("hamzah");
    }

    public void LamAlif()
    {
        Application.LoadLevel("lamalif");
    }

    public void Ha()
    {
        Application.LoadLevel("ha");
    }

    public void Ya()
    {
        Application.LoadLevel("ya");
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

using UnityEngine;
using System.Collections;

public class splashscreen : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel("MenuUtama");
    }
}

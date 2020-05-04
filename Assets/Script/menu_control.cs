using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_control : MonoBehaviour
{
    public GameObject confirm;
    // Start is called before the first frame update
    void Start()
    {
        confirm.SetActive(false);
    }

    public void GoBack()
    {
        confirm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;
using System;

public class splashControl : MonoBehaviour
{
    void Starat()
    {
      
        Invoke("Playasdq", 2);
    }


    void Updsate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Playdasdq()
    {
        Application.LoadLevel("Home");
    }

    void Start()
    {
      
        Invoke("Playasdq", 2);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Playasdq()
    {
        Application.LoadLevel("Home");
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard_handler : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        quitgame();
    }
    
    void quitgame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}

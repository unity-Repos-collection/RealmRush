using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboard_handler : MonoBehaviour
{
    AudioSource As;
    // Start is called before the first frame update
    void Start()
    {
        As = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {   
        quitgame();
        togglesound();
    }
    
    void quitgame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    //debug keyboard keys
    //TODO remove from builds 
    void togglesound()
    {   
        
        
        if (Input.GetKey(KeyCode.S))
        {
            As.enabled = false;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            As.enabled = true;
        } 
         
    }
}

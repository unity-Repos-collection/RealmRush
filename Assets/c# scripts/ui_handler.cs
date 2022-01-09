using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_handler : MonoBehaviour
{   
    [SerializeField] bool start;
    [SerializeField] bool restart;
    [SerializeField] bool quit;
    public void startbutton(bool uibutton)
    {
        start = uibutton;
        if (uibutton == true)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void restartbutton(bool restartbutton)
    {
        restart = restartbutton;
        if (restartbutton == true)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void quitbutton(bool quitbutton)
    {
        quit = quitbutton;
        if (quitbutton == true)
        {
            Application.Quit();
        }
    }


}


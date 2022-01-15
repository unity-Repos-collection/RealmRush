using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_handler : MonoBehaviour
{   
    [SerializeField] bool start;
    [SerializeField] bool restart;
    [SerializeField] bool quit;

    //work on this 
    void Start() 
    {   
        
    }

    public void startbutton(bool uibutton)
    {
        start = uibutton;
        if (uibutton == true)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    public void restartbutton(bool restartbutton)
    {
        restart = restartbutton;
        if (restartbutton == true)
        {   
            int restartscene = SceneManager.GetActiveScene().buildIndex -1;
            SceneManager.LoadScene(restartscene);
        }
    }

    public void quitbutton(bool quitbutton)
    {
        quit = quitbutton;
        if (quitbutton == true)
        {   
            #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
                Debug.Log(this.name+" : "+this.GetType()+" : "+System.Reflection.MethodBase.GetCurrentMethod().Name); 
            #endif
            #if (UNITY_EDITOR)
                UnityEditor.EditorApplication.isPlaying = false;
                Application.OpenURL("https://github.com/Maximus2709");
                Application.OpenURL("https://www.facebook.com/luca.farci.37/");
            #elif (UNITY_STANDALONE)    
                Application.Quit();
            #elif (UNITY_WEBGL)   
                Application.OpenURL("https://github.com/Maximus2709");
                Application.OpenURL("https://www.facebook.com/luca.farci.37/");
            #endif
        }
    }
}


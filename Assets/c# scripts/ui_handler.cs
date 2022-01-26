using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ui_handler : MonoBehaviour
{   
    [SerializeField] bool start;
    [SerializeField] bool restart;
    [SerializeField] bool quit;
    [SerializeField] AudioClip sound;
    
    fade fade;
    
    AudioSource As;
    

    void Awake() 
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60; 
        As = GetComponent<AudioSource>();
        fade = GetComponent<fade>();
    }
    
    void Start() 
    {  
        
    }
    void Update() 
    {
        fade.fadeto();
        
    }

    public void startbutton(bool uibutton)
    {
        start = uibutton;
        if (uibutton == true)
        {   
            fade.fadeto();
            playclicksound();
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    public void restartbutton(bool restartbutton)
    {
        restart = restartbutton;
        if (restartbutton == true)
        {   
            playclicksound();
            int restartscene = SceneManager.GetActiveScene().buildIndex -1;
            SceneManager.LoadScene(restartscene);
        }
    }

    public void quitbutton(bool quitbutton)
    {
        quit = quitbutton;
        if (quitbutton == true)
        {   
            playclicksound();
            #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
                Debug.Log(this.name+" : "+this.GetType()+" : "+System.Reflection.MethodBase.GetCurrentMethod().Name); 
            #endif
            #if (UNITY_EDITOR)
                UnityEditor.EditorApplication.isPlaying = false;
                Application.OpenURL("https://github.com/Maximus2709");
            #elif (UNITY_STANDALONE)    
                Application.Quit();
            #elif (UNITY_WEBGL)   
                Application.OpenURL("https://github.com/Maximus2709");
            #endif
        }
    }
    void playclicksound()
    {
        As.Stop();
        As.PlayOneShot(sound);
    }
}


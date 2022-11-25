using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
        Application.targetFrameRate = -1;
        As = GetComponent<AudioSource>();
        fade = GetComponent<fade>();
    }
    
    void Start() 
    {  
        StartCoroutine(fade.lerpalphaIn());
    }
    void Update() 
    {
        
    }

    public void startbutton(bool uibutton)
    {
        start = uibutton;
        if (uibutton == true)
        {   
            StartCoroutine(fade.lerpalphaOut());
            playclicksound();
            Invoke(nameof(nextscene),fade.fadedelay);
            
        }
    }
    public void restartbutton(bool restartbutton)
    {
        restart = restartbutton;
        if (restartbutton == true)
        {   
            playclicksound();
            restartscene();
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
            #elif (UNITY_STANDALONE)    
                Application.Quit();
            #elif (UNITY_WEBGL)
                Application.OpenURL("https://lucashousestudios.co.uk/unity.html");   
            #endif
        }
    }
    void playclicksound()
    {
        As.Stop();
        As.PlayOneShot(sound);
    }

    public void nextscene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
    void restartscene()
    {
        int restartscene = SceneManager.GetActiveScene().buildIndex -1;
        SceneManager.LoadScene(restartscene);
    }

}


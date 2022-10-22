using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introscene : MonoBehaviour
{
    CanvasGroup canvasGroup;
    
        void Awake() 
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
       
       StartCoroutine(lerpIn());
       Invoke(nameof(nextscene), 5f);
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void nextscene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);      
    }
    
    public IEnumerator lerpIn() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) 
        {
        canvasGroup.alpha = Mathf.Lerp(0f, 1f, f / 2);      
        yield return null;
        }
        canvasGroup.alpha = 1;
    }

    public IEnumerator lerpOut() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) {
        canvasGroup.alpha = Mathf.Lerp(1f, 0f, f / 2);      
        yield return null;
    }
        canvasGroup.alpha = 0;
    }
}

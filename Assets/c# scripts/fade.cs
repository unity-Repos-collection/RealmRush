using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class fade : MonoBehaviour
{  
    public float fadeintime = 1f;
    public float fadeouttime = 2f;
    public float fadedelay = 3f;

    CanvasGroup canvasGroup;
    [SerializeField] Image background;
    [SerializeField] Color backgroundcolor;
    [SerializeField] Color textcolor;
    [SerializeField] Canvas canvas;
    TextMeshProUGUI [] textlist;
    void Awake() 
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponent<Canvas>();
        textlist = GetComponentsInChildren<TextMeshProUGUI>();
        background = GetComponentInChildren<Image>(); 
        canvas.enabled = true;
    }
    
    public IEnumerator colorlerpin()
    {
        for (float t = 0.01f; t < fadeintime; t+=0.01f)
        {
            background.color = Color.Lerp(background.color, backgroundcolor,t/fadeintime);
            foreach(TextMeshProUGUI text in textlist)
            {
                text.color = Color.Lerp(text.color, textcolor, t/fadeintime);
            }  
            yield return null;
        }
    }

    public IEnumerator colorlerpout()
    {
        for (float t = 0.01f; t < fadeintime; t+=0.01f)
        {
            background.color = Color.Lerp(backgroundcolor, Color.black,t/fadeintime);
            foreach(TextMeshProUGUI text in textlist)
            {
                text.color = Color.Lerp(text.color, Color.black, t/fadeintime);
            }  
            yield return null;
        }
    }
    public IEnumerator lerpalphaIn() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) {
        canvasGroup.alpha = Mathf.Lerp(0f, 1f, f / 2);      
        yield return null;
    }
        canvasGroup.alpha = 1;
    }

    public IEnumerator lerpalphaOut() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) {
        canvasGroup.alpha = Mathf.Lerp(1f, 0f, f / 2);      
        yield return null;
    }
        canvasGroup.alpha = 0;
    }

} 
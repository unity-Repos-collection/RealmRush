using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System;
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
        canvas.enabled = true;
    }
    
    
    public IEnumerator lerpalphaIn() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) 
        {
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
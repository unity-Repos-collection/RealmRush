using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class fade : MonoBehaviour
{  
    [SerializeField] Image background;
    
    [SerializeField] TextMeshProUGUI textmeshpro; 
    [SerializeField] Color backgroundcolor;
    [SerializeField] Color textcolor;
    [SerializeField] [Range(0f,1f)] float lerpTime;
    [SerializeField] Canvas canvas;
    
    
    void Awake() 
    {
        canvas = GetComponent<Canvas>();
        background = GetComponentInChildren<Image>(); 
        textmeshpro = GetComponentInChildren<TextMeshProUGUI>();
        canvas.enabled = true;
    }
    
    public void fadeto()
    {   
        if(canvas.enabled == true)
        {
        background.color = Color.Lerp(background.color, backgroundcolor, lerpTime);
        textmeshpro.color = Color.Lerp(textmeshpro.color, textcolor, lerpTime); 
        }
        else
        {
            return;
        }
    }
      
}

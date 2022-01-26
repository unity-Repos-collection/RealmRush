using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class fade : MonoBehaviour
{  
    [SerializeField] Image background;
    [SerializeField] Color backgroundcolor;
    [SerializeField] Color textcolor;
    [SerializeField] Canvas canvas;
    [SerializeField] float lerpTime = 0.5f;
    
    TextMeshProUGUI [] textlist;
    void Awake() 
    {
        canvas = GetComponent<Canvas>();

        textlist = GetComponentsInChildren<TextMeshProUGUI>();
        background = GetComponentInChildren<Image>(); 
        canvas.enabled = true;
    }
    
    public void fadeto()
    {   
        if(canvas.enabled == true)
        {
            background.color = Color.Lerp(background.color, backgroundcolor,Mathf.PingPong(Time.time, lerpTime));
            foreach(TextMeshProUGUI text in textlist)
            {
                text.color = Color.Lerp(text.color, textcolor, lerpTime);
            }    
        }
        else
        {
            return;
        }
    }
      
}

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
    // Start is called before the first frame update
    
    
    void Awake() 
    {
       background = GetComponentInChildren<Image>(); 
       textmeshpro = GetComponentInChildren<TextMeshProUGUI>();
    }
    
    public void fadeto()
    {   
        background.color = Color.Lerp(background.color, backgroundcolor, lerpTime);
        textmeshpro.color = Color.Lerp(textmeshpro.color, textcolor, lerpTime); 
    }
      
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_lerp : MonoBehaviour
{ 
    [SerializeField] Image image;
    Color startcolor = new Color32(0,0,0,255);
    Color endcolor = new Color32(0,0,0,0);
    float time = 1f;
    // Start is called before the first frame update
    void Awake() 
    {
        image = GetComponentInChildren<Image>();
    }
    void Start()
    {
        StartCoroutine(lerpsceneOut());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public IEnumerator lerpsceneOut() 
    {
        for(float f = 0; f <= 2; f += Time.deltaTime) 
        {
            image.color = Color.Lerp(startcolor, endcolor, f/time);
            yield return null;
        }
        
    }
}

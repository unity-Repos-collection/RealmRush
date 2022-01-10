using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateram : MonoBehaviour
{
    
    [SerializeField ]Animation anim;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>();         
    }

    // Update is called once per frame
    void Update()
    {   
        playanim(); 
           
    }



    public void playanim()
    {   
        
        anim.Play("ram_02_move");
        
    }
    public void stopanimation()
    {   
        
        anim.Stop("ram_02_move");
    } 
    

    
}

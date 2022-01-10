using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateballista : MonoBehaviour
{
    [SerializeField] Animation animball;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //playanimball();
    } 
    public void playanimball()
    {   
        
        animball.Play("ballista_03_attack");
        
    }
    public void stopanimball()
    {
        animball.Stop("ballista_03_attack");
    }
    
}

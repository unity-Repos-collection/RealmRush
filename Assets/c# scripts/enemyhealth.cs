using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int maxhealth = 5;
    [SerializeField] int currenthitpoints; 
    void OnEnable()
    {
        currenthitpoints = maxhealth;
    }
    
    
    
    void OnParticleCollision(GameObject other) 
    {
        processHit();
    }
    void processHit()
    {   
        currenthitpoints--;

        if(currenthitpoints <= 0)
        {
            gameObject.SetActive(false);    
            Debug.Log("destroyed");
        }

    }
}

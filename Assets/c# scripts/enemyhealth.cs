using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int maxhealth = 5;
    
    [SerializeField] int currenthitpoints; 
    enemy enemy;
    void OnEnable()
    {
        currenthitpoints = maxhealth;
    }
    
    void Start() 
    {
        enemy = GetComponent<enemy>();
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
            enemy.rewardgold();   
            Debug.Log("destroyed");
        }

    }
}

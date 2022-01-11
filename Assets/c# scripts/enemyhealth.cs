using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(enemy))]
public class enemyhealth : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("States max enemy(ram) health")]
    [SerializeField] int maxhealth = 5;
    
    [Tooltip("Adds amount to max hit points when enemy dies")]     
    [SerializeField] int difficultyramp = 1;
    
    
    int currenthitpoints; 
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
            maxhealth += difficultyramp;
            enemy.rewardgold();   
        }

    }
}

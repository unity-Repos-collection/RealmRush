using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    [SerializeField] Tower towerprefab;
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable{ get { return isPlaceable; } }
    
    void OnMouseDown() 
    {   
        if (isPlaceable)
        {   
            bool isPlaced = towerprefab.CreateTower(towerprefab, transform.position); 
            isPlaceable = !isPlaced;
        }

    }
    
    
}

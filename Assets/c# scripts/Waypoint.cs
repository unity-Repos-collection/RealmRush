using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerprefab;
    [SerializeField] bool isPlaceable;
    public bool IsPlaceable{ get { return isPlaceable; } }
    

    void OnMouseDown() 
    {   
        if (isPlaceable)
        {
            Instantiate(towerprefab, transform.position, Quaternion.identity);
            isPlaceable = false;
            //Debug.Log(transform.name);    
        }
    }
    
    
}

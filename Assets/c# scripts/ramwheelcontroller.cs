using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramwheelcontroller : MonoBehaviour
{
    [SerializeField] float rotatespeed = 0.5f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotatewheels();
    }

    void rotatewheels()
    {
        transform.Rotate(-1,0,0 * rotatespeed);
    }
}

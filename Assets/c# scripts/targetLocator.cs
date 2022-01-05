using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    Transform target; 
    // Start is called before the first frame update
    
    void Update()
    {
        findclosesttarget();
        aimweapon();

    }
    void findclosesttarget()
    {
        
    }
    void aimweapon()
    {
        weapon.LookAt(target);
    }
}

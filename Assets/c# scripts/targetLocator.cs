using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] ParticleSystem projectileParticles;
    [SerializeField] float range = 15f;
    Transform target; 
    // Start is called before the first frame update
    
    void Update()
    {
        findclosesttarget();
        aimweapon();

    }
    void findclosesttarget()
    {
        enemy[] enemies =FindObjectsOfType<enemy>();
        Transform closestTarget =null;
        float maxDistance = Mathf.Infinity;
        foreach(enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if (targetDistance < maxDistance)
            {
                closestTarget = enemy.transform;
                maxDistance = targetDistance;    
            }
        }
        target = closestTarget;
    }
    void aimweapon()
    {   
        float targetDistance = Vector3.Distance(transform.position, target.position);
        weapon.LookAt(target);

        if (targetDistance < range)
        {
            Attack(true);
        }
        else
        {
           Attack(false); 
        }
    }
    void Attack(bool isActive)
    {
        var emissionModule = projectileParticles.emission;
        emissionModule.enabled = isActive;
    }

}

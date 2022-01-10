using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f,5f)] float speed = 1f;
    
    animateram animateram;
    enemy enemy;
    void OnEnable()
    {
        findpath();
        returntostart();
        StartCoroutine (FollowPath());
         
    }
    void Start() 
    {
        animateram = GetComponent<animateram>();
        enemy = GetComponent<enemy>();    
    }
    void findpath()
    {   
        path.Clear();
        GameObject parent = GameObject.FindGameObjectWithTag("Path");
        
        foreach (Transform child in parent.transform)
        {
            Waypoint waypoint = child.GetComponent<Waypoint>();
            if (waypoint != null)
            {
                path.Add(waypoint);
            }
        }
    }
    void returntostart()
    {
        transform.position = path[0].transform.position;
    }
    IEnumerator FollowPath() 
    {
        foreach(Waypoint waypoint in path) 
        {   
            Vector3 startposition = transform.position;
            Vector3 nextposition = waypoint.transform.position;
            float travelpecentage = 0f;
            
            transform.LookAt(nextposition);
            
            while(travelpecentage < 1)
            {
                travelpecentage += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startposition,nextposition, travelpecentage);
                yield return new WaitForEndOfFrame();
            }
        }
        enemy.stealgold();
        gameObject.SetActive(false); 
        
    } 

    
    
}

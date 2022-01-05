using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpool : MonoBehaviour
{   
    public bool stop;
    [SerializeField] int poolsize = 5;
    [SerializeField] GameObject ram;
    [SerializeField] float betweenspawns = 2f;

    GameObject[] pool;  

    void Awake() 
    {
        populatepool();    
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (spawnenemy());
        
    }
    void populatepool()
    {
        pool = new GameObject[poolsize];

        for (int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(ram , transform);
            pool[i].SetActive(false);
        }
    }

    void enableobjectinpool()
    {
        for (int i = 0; i < pool.Length; i++)
        {
            if (pool[i].activeInHierarchy == false)
            {
                pool[i].SetActive(true);
                return;
            }
        }
    }
    IEnumerator spawnenemy()
    {   
        while (true)
        {
            enableobjectinpool();
            yield return new WaitForSeconds(betweenspawns);
        }
    }
}

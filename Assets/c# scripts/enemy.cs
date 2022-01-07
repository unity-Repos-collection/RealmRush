using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] int goldreward = 25;
    [SerializeField] int goldpenalty = 25;
    Bank bank;
    void Start() 
    {
        bank = FindObjectOfType<Bank>();    
    } 

    public void rewardgold()
    {   
        if(bank == null) {return;}
        bank.deposit(goldreward);
    } 

    public void stealgold()
    {
        if(bank == null) {return;}
        bank.withdraw(goldpenalty);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;
    public int CurrentBalance {get {return currentBalance; } }
    
    void Awake()
    {
        currentBalance = startingBalance;
    }
    public void deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
    }
    public void withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
    }
}
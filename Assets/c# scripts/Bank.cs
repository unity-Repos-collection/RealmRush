using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI displaybank;
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;
    
    public int CurrentBalance {get {return currentBalance; } }
    void Awake()
    {
        currentBalance = startingBalance;
        updateDisplay();
    }

    void Update() 
    {
        wingame();
    }
    public void deposit(int amount)
    {   
        currentBalance += Mathf.Abs(amount);
        updateDisplay();
    }
    
    public void withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        updateDisplay();
        if (currentBalance < 0)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(2);
        }
       

    }
    void updateDisplay()
    {
        displaybank.text = "Gold: " + currentBalance; 
    }
    void wingame()
    {
        if(currentBalance >= 175)
        {
            SceneManager.LoadScene(3);
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance;
    public int CurrentBalance {get {return currentBalance; } }
    
    [SerializeField] float restartTime = 5f;
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
        if (currentBalance < 0)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(0);
        }
    }
}

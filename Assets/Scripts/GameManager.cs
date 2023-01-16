using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public HealthUI healthUI;

    [SerializeField] private int currentLevel;
    public int CurrentLevel
    {
        get
        {
            return currentLevel;
        }
        set
        {
            currentLevel = value;
        }
    }
    [SerializeField] private int totalHealthPoint;
    public int TotalHealthPoint 
    {
        get
        {
            return totalHealthPoint;
        }
        set
        {
            if(totalHealthPoint == 0)
            {
                RestartGame();
            }
            else
            {
                totalHealthPoint = value;
                healthUI.UpdateHealth();
            }
        }
    }

    private static GameManager Intstance { get { return instance; } }
    private static GameManager instance;
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void RestartGame()
    {

    }
}

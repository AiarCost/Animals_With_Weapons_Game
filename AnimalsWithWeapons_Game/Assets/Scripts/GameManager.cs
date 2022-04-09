using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player playerClass = null;
    public Player enemyClass = null;

    //instance
    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }

    public void PlayerCreated(Player player)
    {
        playerClass = player;

        Debug.Log("Player Created." + playerClass.AnimalPlayer.AnimalName + playerClass.WeaponPlayer.WeaponName);
    }

    public void EnemyCreated(Player enemy)
    {
        enemyClass = enemy;

        Debug.Log("Enemy Created." + enemyClass.AnimalPlayer.AnimalName + enemyClass.WeaponPlayer.WeaponName);
    }
}

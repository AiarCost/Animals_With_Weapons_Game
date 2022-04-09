using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player playerClass;
    public Player enemyClass;

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
}

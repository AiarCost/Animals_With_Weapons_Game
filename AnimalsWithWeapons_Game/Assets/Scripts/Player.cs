using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player 
{
    public Animal AnimalPlayer;
    public Weapon WeaponPlayer;

    public GameObject HealthImage;
    public TextMeshProUGUI RemainingHealth;
    public int TotalHealth;
   public Player( Animal AnimalChosen, Weapon WeaponChosen)
    {
        AnimalPlayer = AnimalChosen;
        WeaponPlayer = WeaponChosen;

       // Debug.Log("Player Created... ready to go");
    }

    public void WeaponAttack(Player user)
    {
        WeaponPlayer.AttackType1(user, AnimalPlayer.DefenseTimes);
        UpdateUI(user);
    }

    public void AnimalAttack(Player user)
    {
        AnimalPlayer.AnimalAttack(user);
        UpdateUI(user);
    }

    public void AnimalDefense()
    {
        AnimalPlayer.AnimalDefense();
    }

    public void Flee()
    {
        //flee
    }


    public void UpdateUI(Player user)
    {
        
        //RemainingHealth.text = AnimalPlayer.Health.ToString();
        user.HealthImage.transform.localScale = new Vector3(user.AnimalPlayer.Health / user.TotalHealth, 1, 1);
    }
}

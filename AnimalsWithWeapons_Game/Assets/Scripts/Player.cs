using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public Animal AnimalPlayer;
    public Weapon WeaponPlayer;


   public Player( Animal AnimalChosen, Weapon WeaponChosen)
    {
        AnimalPlayer = AnimalChosen;
        WeaponPlayer = WeaponChosen;

        Debug.Log("Player Created... ready to go");
    }

    public void WeaponAttack(Player user)
    {
        WeaponPlayer.AttackType1(user, AnimalPlayer.DefenseTimes);
    }

    public void AnimalAttack(Player user)
    {
        AnimalPlayer.AnimalAttack(user);
    }

    public void AnimalDefense()
    {
        AnimalPlayer.AnimalDefense();
    }

    public void Flee()
    {
        //flee
    }
}

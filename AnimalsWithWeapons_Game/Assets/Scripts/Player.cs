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
    }

    public void WeaponAttack()
    {
        WeaponPlayer.AttackType1();
    }

    public void AnimalAttack()
    {
        AnimalPlayer.AnimalAttack();
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    Animal AnimalPlayer;
    Weapon WeaponPlayer;

    Player( Animal AnimalChosen, Weapon WeaponChosen)
    {
        AnimalPlayer = AnimalChosen;
        WeaponPlayer = WeaponChosen;
    }

    public void Attack1()
    {
        WeaponPlayer.AttackType1();
    }

    public void Attack2()
    {
        WeaponPlayer.AttackType2();
    }

    public void Utility1()
    {
        AnimalPlayer.Utility1();
    }

    public void Utility2()
    {
        AnimalPlayer.Utility2();
    }
}

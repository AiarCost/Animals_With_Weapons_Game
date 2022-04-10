using UnityEngine;


interface IWeapon
{
    public void AttackType1(Player user, int StaticDefense);
}

public class Weapon : IWeapon
{
    public string WeaponName;
    public float Damage;
    public string Attack1Name;
    public Sprite WeaponImage;


    public void AttackType1(Player user, int StaticDefense)
    {
        if (user.AnimalPlayer.InDefense)
        {
            int roll = Random.Range(0, 100);
            if (roll <= user.AnimalPlayer.defense)
            {
                Debug.LogFormat("{0}'s Attack has missed on {1}", WeaponName, user.AnimalPlayer.AnimalName);
            }
            else
            {
                user.AnimalPlayer.Health -= this.Damage;
                Debug.LogFormat("{0} has taken {1} damage from {2}! Health is now: {3}", user.AnimalPlayer.AnimalName, Damage, Attack1Name, user.AnimalPlayer.Health);
            }
            user.AnimalPlayer.defenseUsed++;

            if (user.AnimalPlayer.defenseUsed >= StaticDefense)
            {
                user.AnimalPlayer.defenseUsed = 0;
                user.AnimalPlayer.InDefense = false;
            }
        }
        else
        {
            user.AnimalPlayer.Health -= this.Damage;
            Debug.LogFormat("{0} has taken {1} damage from {2}! Health is now: {3}", user.AnimalPlayer.AnimalName, Damage, Attack1Name, user.AnimalPlayer.Health);
        }
    }

}


public class Chainsaw : Weapon
{

    public Chainsaw(Sprite WeaponSprite)
    {
        WeaponName = "Chainsaw";
        Attack1Name = "BRRRR";
        WeaponImage = WeaponSprite;
        Damage = 10;
       
    }

}

public class DesertEagle : Weapon
{

    public DesertEagle(Sprite WeaponSprite)
    {
        WeaponName = "Desert Eagle";
        Attack1Name = "Desert Aim";
        WeaponImage = WeaponSprite;
        Damage = 15;
    }


}


public class Flamethrower : Weapon
{

    public Flamethrower(Sprite WeaponSprite)
    {
        WeaponName = "Flamethrower";
        Attack1Name = "Pyro Attack";
        WeaponImage = WeaponSprite;
        Damage = 15;
    }

}

public class Knife : Weapon
{

    public Knife(Sprite WeaponSprite)
    {
        WeaponName = "Knife";
        Attack1Name = "Sharp Slice";
        WeaponImage = WeaponSprite;
        Damage = 5;
    }

}


public class MorningStar : Weapon
{

    public MorningStar(Sprite WeaponSprite)
    {
        WeaponName = "Morning Star";
        Attack1Name = "Heavy Swing";
        WeaponImage = WeaponSprite;
        Damage = 10;
    }

}

public class Shuriken : Weapon
{

    public Shuriken(Sprite WeaponSprite)
    {
        WeaponName = "Shuriken";
        Attack1Name = "Ninja Style";
        WeaponImage = WeaponSprite;
        Damage = 5;
    }

}
using UnityEngine;


interface IWeapon
{
    public void AttackType1();
}

public class Weapon : IWeapon
{
    public string WeaponName;
    public float Damage;
    public string Attack1;
    public Sprite WeaponImage;


    public virtual void AttackType1()
    {
        Debug.Log("Weapon function ran!");
    }

}


public class Chainsaw : Weapon, IWeapon
{

    public Chainsaw(Sprite WeaponSprite)
    {
        WeaponName = "Chainsaw";

       
    }

    public override void AttackType1()
    {
        
    }
}

public class DesertEagle : Weapon
{

    public DesertEagle(Sprite WeaponSprite)
    {
        WeaponName = "Desert Eagle";

        
    }

    public override void AttackType1()
    {
       
    }
}


public class Flamethrower : Weapon
{

    public Flamethrower(Sprite WeaponSprite)
    {
        WeaponName = "Flamethrower";

        
    }

    public override void AttackType1()
    {
        
    }
}

public class Knife : Weapon
{

    public Knife(Sprite WeaponSprite)
    {
        WeaponName = "Knife";

        
    }

    public override void AttackType1()
    {
        
    }
}


public class MorningStar : Weapon
{

    public MorningStar(Sprite WeaponSprite)
    {
        WeaponName = "Morning Star";

        
    }

    public override void AttackType1()
    {
        
    }
}

public class Shuriken : Weapon
{

    public Shuriken(Sprite WeaponSprite)
    {
        WeaponName = "Shuriken";

        
    }

    public override void AttackType1()
    {
       
    }
}
using UnityEngine;
interface IAnimal
{
    public abstract void AnimalAttack(Player user);

    public abstract void AnimalDefense();
}


public class Animal: IAnimal
{
    public string AnimalName;
    public float Health;
    public int speed;
    public int defense;
    public int DefenseTimes = 3;
    public int defenseUsed = 0;
    public Sprite AnimalImage;
    public bool InDefense = false;

    public string Attack1Name;
    public int Attack1Damage;
    public string Defense1Name;

    public void  AnimalAttack(Player user) {

        if (user.AnimalPlayer.InDefense)
        {
            int roll = Random.Range(0, 100);
            if (roll <= user.AnimalPlayer.defense)
            {
                Debug.LogFormat("{0}'s Attack has missed on {1}",this.AnimalName, user.AnimalPlayer.AnimalName);
            }
            else
            {
                user.AnimalPlayer.Health -= this.Attack1Damage;
                Debug.LogFormat("{0} has taken {1} damage from {2}! Health is now: {3}", user.AnimalPlayer.AnimalName, Attack1Damage, Attack1Name, user.AnimalPlayer.Health);
            }
            user.AnimalPlayer.defenseUsed++;

            if (user.AnimalPlayer.defenseUsed >= DefenseTimes)
            {
                user.AnimalPlayer.defenseUsed = 0;
                user.AnimalPlayer.InDefense = false;
            }
        }
        else
        {
            user.AnimalPlayer.Health -= this.Attack1Damage;
            Debug.LogFormat("{0} has taken {1} damage from {2}! Health is now: {3}", user.AnimalPlayer.AnimalName, Attack1Damage, Attack1Name, user.AnimalPlayer.Health);
        }
    }


    public void AnimalDefense() 
    {
        InDefense = true;
        Debug.LogFormat("{0}'s {1} activated!", AnimalName, Defense1Name); 
    }
}


public class Chicken : Animal
{
    public Chicken(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 80f;
        this.speed = 40;
        this.defense = 60;
        this.Attack1Damage = 10;
        this.Attack1Name = "Peck";
        this.Defense1Name = "Wing Flaps";
        this.AnimalImage = AnimalImage;
    }


}

public class Bear : Animal
{
    public Bear(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 100f;
        this.speed = 10;
        this.defense = 20;
        this.AnimalImage = AnimalImage;
        Attack1Name = "Claws";
        Defense1Name = "Roar";
        this.Attack1Damage = 15;
    }

}

public class Ferret : Animal
{
    public Ferret(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 70f;
        this.speed = 50;
        this.defense = 70;
        this.Attack1Name = "Wiggle";
        this.Defense1Name = "Ball-up";
        this.Attack1Damage = 10;
        this.AnimalImage = AnimalImage;
    }


}

public class Frog : Animal
{
    public Frog(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 60f;
        this.speed = 30;
        this.defense = 70;
        this.Attack1Name = "Lick";
        this.Defense1Name = "Jump";
        this.Attack1Damage = 10;
        this.AnimalImage = AnimalImage;
    }


}

public class Giraffe : Animal
{
    public Giraffe(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 90f;
        this.speed = 20;
        this.defense = 10;
        this.Attack1Name = "Neck Whip";
        this.Defense1Name = "High Neck";
        this.Attack1Damage = 15;
        this.AnimalImage = AnimalImage;
    }

 
}

public class Salamander : Animal
{
    public Salamander(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 50f;
        this.speed = 60;
        this.defense = 50;
        this.Attack1Name = "Toxin";
        this.Defense1Name = "Hideaway";
        this.Attack1Damage = 20;
        this.AnimalImage = AnimalImage;
    }

}
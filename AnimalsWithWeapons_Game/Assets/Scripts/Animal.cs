using UnityEngine;
public class Animal
{
    public string AnimalName;
    public float Health;
    public int speed;
    public int defense;
    public Sprite AnimalImage;

    public string Attack1Name;
    public string Defense1Name;

    public virtual float  AnimalAttack() { return 0f; }
    public virtual void AnimalDefense() { Debug.Log("The Animal Class function ran!"); }
}

interface IAnimal
{
    public abstract float  AnimalAttack();

    public abstract void AnimalDefense();
}
public class Chicken : Animal, IAnimal
{
    public Chicken(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 40;
        this.defense = 60;
        this.AnimalImage = AnimalImage;

        AnimalDefense();
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {
        Debug.Log("The Chicken Class Function Ran!");
    }
}

public class Bear : Animal, IAnimal
{
    public Bear(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 10;
        this.defense = 20;
        this.AnimalImage = AnimalImage;
        Attack1Name = "Claws";
        Defense1Name = "ROAR";
    }

    public override float AnimalAttack()
    {

        Debug.Log("Bear Attack");

        return 0f;
    }

    public override void AnimalDefense()
    {
        Debug.Log("Bear Defense");
    }
}

public class Ferret : Animal, IAnimal
{
    public Ferret(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 50;
        this.defense = 70;
        this.AnimalImage = AnimalImage;
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {

    }
}

public class Frog : Animal, IAnimal
{
    public Frog(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 30;
        this.defense = 70;
        this.AnimalImage = AnimalImage;
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {

    }
}

public class Giraffe : Animal, IAnimal
{
    public Giraffe(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 20;
        this.defense = 10;
        this.AnimalImage = AnimalImage;
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {

    }
}

public class Salamander : Animal, IAnimal
{
    public Salamander(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 60;
        this.defense = 50;
        this.AnimalImage = AnimalImage;
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {

    }
}
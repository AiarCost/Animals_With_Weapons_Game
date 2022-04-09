using UnityEngine;
public class Animal
{
    public string AnimalName;
    public float Health;
    public int speed;
    public int defense;
    public Sprite AnimalImage;

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
        this.speed = 0;
        this.defense = 0;
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
        this.speed = 0;
        this.defense = 0;
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

public class Ferret : Animal, IAnimal
{
    public Ferret(string AnimalName, Sprite AnimalImage)
    {
        this.AnimalName = AnimalImage.name;
        this.Health = 0f;
        this.speed = 0;
        this.defense = 0;
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
        this.speed = 0;
        this.defense = 0;
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
        this.speed = 0;
        this.defense = 0;
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
        this.speed = 0;
        this.defense = 0;
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
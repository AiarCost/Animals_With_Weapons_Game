using UnityEngine;
public class Animal
{
    protected string AnimalName;
    protected float Health;
    protected int speed;
    protected int defense;
    protected Sprite AnimalImage;

    public virtual float  AnimalAttack() { return 0f; }
    public virtual void AnimalDefense() { }
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
    }

    public override float AnimalAttack()
    {



        return 0f;
    }

    public override void AnimalDefense()
    {

    }
}
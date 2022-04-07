using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public Sprite[] AnimalImages, WeaponImages;
    public Image AnimalImage, WeaponImage;
    int WeaponIndex =0, AnimalIndex=0;

    public Animal AnimalChosen;
    public Weapon WeaponChosen;



    public void AnimalConfirmation()
    {

    }
    public void WeaponConfirmation()
    {

    }


    public void MoveRightAnimals()
    {

    }

    private void Start()
    {
        AnimalImage.sprite = AnimalImages[0];
        WeaponImage.sprite = WeaponImages[0];
    }
}

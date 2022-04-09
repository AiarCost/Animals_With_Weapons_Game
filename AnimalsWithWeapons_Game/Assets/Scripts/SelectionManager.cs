using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionManager : MonoBehaviour
{
    public Sprite[] AnimalImages, WeaponImages;
    public Image AnimalImage, WeaponImage;
    int WeaponIndex =0, AnimalIndex=0;

    public GameObject warningText;

    public Animal AnimalChosen;
    public Weapon WeaponChosen;



    public void CompleteSelection()
    {

        try
        {
            if(AnimalChosen == null || WeaponChosen == null)
            {
                throw new NullReferenceException();
            }
            Player CreatePlayer = new Player(AnimalChosen, WeaponChosen);

            GameManager.instance.PlayerCreated(CreatePlayer);

            
        }
        catch(NullReferenceException ex)
        {
            StartCoroutine("Warning");
        }
        catch
        {
            StartCoroutine("Warning");
        }
    }

    public IEnumerator Warning()
    {
        warningText.SetActive(true);

        yield return new WaitForSeconds(3f);

        warningText.SetActive(false);

    }

    public void AnimalConfirmation()
    {

        switch (AnimalIndex)
        {
            case 0:
                AnimalChosen = new Bear("Bear", AnimalImages[AnimalIndex]);
                break;
            case 1:
                AnimalChosen = new Chicken("Chicken", AnimalImages[AnimalIndex]);
                break;
            case 2:
                AnimalChosen = new Ferret("Ferret", AnimalImages[AnimalIndex]);
                break;
            case 3:
                AnimalChosen = new Frog("Frog", AnimalImages[AnimalIndex]);
                break;
            case 4:
                AnimalChosen = new Giraffe("Giraffe", AnimalImages[AnimalIndex]);
                break;
            case 5:
                AnimalChosen = new Salamander("Salamander", AnimalImages[AnimalIndex]);
                break;
                
        }

        Debug.Log(AnimalChosen.AnimalName);
    }
    public void WeaponConfirmation()
    {
        switch (WeaponIndex)
        {
            case 0:
                WeaponChosen = new Chainsaw(WeaponImages[WeaponIndex]);
                break;
            case 1:
                WeaponChosen = new DesertEagle(WeaponImages[WeaponIndex]);
                break;
            case 2:
                WeaponChosen = new Flamethrower(WeaponImages[WeaponIndex]);
                break;
            case 3:
                WeaponChosen = new Knife(WeaponImages[WeaponIndex]);
                break;
            case 4:
                WeaponChosen = new MorningStar(WeaponImages[WeaponIndex]);
                break;
            case 5:
                WeaponChosen = new Shuriken(WeaponImages[WeaponIndex]);
                break;

        }

        Debug.Log(WeaponChosen.WeaponName);
    }


    public void WeaponCancel()
    {
        WeaponChosen = null;
    }
    public void AnimalCancel()
    {
        AnimalChosen = null;
    }


    public void MoveRightAnimals()
    {
        AnimalIndex++;
        if (AnimalIndex < 0)
        {
            AnimalIndex = 0;

        }
        else if (AnimalIndex > 5)
        {
            AnimalIndex = 5;
        }
        else
        {
            AnimalImage.sprite = AnimalImages[AnimalIndex % 6];
        }

    }

    public void MoveLeftAnimals()
    {
        AnimalIndex--;
        if (AnimalIndex < 0)
        {
            AnimalIndex = 0;

        }
        else if (AnimalIndex > 5)
        {
            AnimalIndex = 5;
        }
        else
        {
            AnimalImage.sprite = AnimalImages[AnimalIndex % 6];
        }

    }

    public void MoveRightWeapons()
    {
        WeaponIndex++;
        if (WeaponIndex < 0)
        {
            WeaponIndex = 0;

        }
        else if (WeaponIndex > 5)
        {
            WeaponIndex = 5;
        }
        else
        {
            WeaponImage.sprite = WeaponImages[WeaponIndex % 6];
        }

    }

    public void MoveLeftWeapons()
    {
        WeaponIndex--;
        if (WeaponIndex < 0)
        {
            WeaponIndex = 0;

        }
        else if (WeaponIndex > 5)
        {
            WeaponIndex = 5;
        }
        else
        {
            WeaponImage.sprite = WeaponImages[WeaponIndex % 6];
        }

    }

    private void Start()
    {
        AnimalImage.sprite = AnimalImages[0];
        WeaponImage.sprite = WeaponImages[0];
        warningText.SetActive(false);
    }


}

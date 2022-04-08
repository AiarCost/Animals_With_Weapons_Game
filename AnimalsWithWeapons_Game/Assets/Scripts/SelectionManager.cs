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

            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().playerClass = CreatePlayer;
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

            case 1:

            case 2:

            case 3:

            case 4:

            case 5:
        }
    }
    public void WeaponConfirmation()
    {
        Debug.Log(WeaponImages[WeaponIndex].name);
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

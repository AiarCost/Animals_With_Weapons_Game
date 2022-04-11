using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectionManager : MonoBehaviour
{
    public Sprite[] AnimalImages, WeaponImages;
    public Button AnimalButton, WeaponButton;
    public Image AnimalImage, WeaponImage;
    int WeaponIndex =0, AnimalIndex=0;

    public GameObject warningText;

    public Animal AnimalChosen = null;
    public Weapon WeaponChosen = null;



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


            //Enemy Creation
            int EnemyAnimal, EnemyWeapon, EnemyName;
            string path = "Assets/Notes/Names.txt", EnemyChangedName;
            StreamReader reader = new StreamReader(path);

            EnemyName = UnityEngine.Random.Range(1, 50);

            for(int i = 1; i < EnemyName; i++)
            {
                reader.ReadLine();
            }

            EnemyChangedName = reader.ReadLine();

            Debug.Log(EnemyChangedName);

            EnemyAnimal = UnityEngine.Random.Range(0, 5);
            EnemyWeapon = UnityEngine.Random.Range(0, 5);
            AnimalConfirmation(EnemyAnimal);
            WeaponConfirmation(EnemyWeapon);
            Player createEnemy = new Player(AnimalChosen, WeaponChosen);
            createEnemy.AnimalPlayer.AnimalName = EnemyChangedName;

            GameManager.instance.EnemyCreated(createEnemy);


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

    public void AnimalConfirmation( int Index)
    {

        switch (Index)
        {
            case 0:
                AnimalChosen = new Bear("Bear", AnimalImages[Index]);
                break;
            case 1:
                AnimalChosen = new Chicken("Chicken", AnimalImages[Index]);
                break;
            case 2:
                AnimalChosen = new Ferret("Ferret", AnimalImages[Index]);
                break;
            case 3:
                AnimalChosen = new Frog("Frog", AnimalImages[Index]);
                break;
            case 4:
                AnimalChosen = new Giraffe("Giraffe", AnimalImages[Index]);
                break;
            case 5:
                AnimalChosen = new Salamander("Salamander", AnimalImages[Index]);
                break;
                
        }

        Debug.Log(AnimalChosen.AnimalName);
    }
    public void WeaponConfirmation(int Index)
    {
        switch (Index)
        {
            case 0:
                WeaponChosen = new Chainsaw(WeaponImages[Index]);
                break;
            case 1:
                WeaponChosen = new DesertEagle(WeaponImages[Index]);
                break;
            case 2:
                WeaponChosen = new Flamethrower(WeaponImages[Index]);
                break;
            case 3:
                WeaponChosen = new Knife(WeaponImages[Index]);
                break;
            case 4:
                WeaponChosen = new MorningStar(WeaponImages[Index]);
                break;
            case 5:
                WeaponChosen = new Shuriken(WeaponImages[Index]);
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

        AnimalButton.onClick.AddListener(() => AnimalConfirmation(AnimalIndex));
        WeaponButton.onClick.AddListener(() => WeaponConfirmation(WeaponIndex));
    }


}

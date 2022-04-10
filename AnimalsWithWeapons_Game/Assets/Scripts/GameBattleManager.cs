using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameBattleManager : MonoBehaviour
{

    public Button Attack1Button, Attack2Button, Defense1Button, FleeButton;
    public Image PAnimalImage, PWeaponImage, EAnimalImage, EWeaponImage;

    Player player = GameManager.instance.playerClass;
    Player enemy = GameManager.instance.enemyClass;

    private void Start()
    {
        Attack1Button.GetComponentInChildren<TextMeshProUGUI>().text = player.AnimalPlayer.Attack1Name;
        Defense1Button.GetComponentInChildren<TextMeshProUGUI>().text = player.AnimalPlayer.Defense1Name;
        Attack2Button.GetComponentInChildren<TextMeshProUGUI>().text = player.WeaponPlayer.Attack1Name;

        Attack1Button.onClick.AddListener(() => player.AnimalAttack(enemy));
        Attack1Button.onClick.AddListener(PlayerChoose);

        Defense1Button.onClick.AddListener(player.AnimalDefense);
        Defense1Button.onClick.AddListener(PlayerChoose);

        Attack2Button.onClick.AddListener(() => player.WeaponAttack(enemy));
        Attack2Button.onClick.AddListener(PlayerChoose);

        FleeButton.onClick.AddListener(Flee);

        PAnimalImage.sprite = player.AnimalPlayer.AnimalImage;
        PWeaponImage.sprite = player.WeaponPlayer.WeaponImage;
        EAnimalImage.sprite = enemy.AnimalPlayer.AnimalImage;
        EWeaponImage.sprite = enemy.WeaponPlayer.WeaponImage;


        if(player.AnimalPlayer.speed >= enemy.AnimalPlayer.speed)
        {
            //player goes first
        }
        else
        {
            PlayerChoose();
        }
    }

    public void Flee()
    {
        Debug.Log("FLeeing!!!");
    }

    public void PlayerChoose()
    {
        Attack1Button.gameObject.SetActive(false);
        Attack2Button.gameObject.SetActive(false);
        Defense1Button.gameObject.SetActive(false);
        FleeButton.gameObject.SetActive(false);

        StartCoroutine(EnemyTurn());

    }


    IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(3f);
        int RanChoice = Random.Range(0, 2);

        switch (RanChoice)
        {
            case 0:
                enemy.AnimalAttack(player);
                break;
            case 1:
                enemy.AnimalDefense();
                break;
            case 2:
                enemy.WeaponAttack(player);
                break;
        }

        yield return new WaitForSeconds(3f);

        Attack1Button.gameObject.SetActive(true);
        Attack2Button.gameObject.SetActive(true);
        Defense1Button.gameObject.SetActive(true);
        FleeButton.gameObject.SetActive(true);
    }
}

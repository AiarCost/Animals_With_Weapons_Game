using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameBattleManager : MonoBehaviour
{

    public Button Attack1Button, Attack2Button, Defense1Button, FleeButton;
    public Image PAnimalImage, PWeaponImage, EAnimalImage, EWeaponImage;

    public GameObject PlayerUI, EnemyUI;

    public ScenesManager Scene;

    public TextMeshProUGUI ActionText, PlayerName, EnemyName, playerHealthText;

    Player player = GameManager.instance.playerClass;
    Player enemy = GameManager.instance.enemyClass;


    private void Awake()
    {

    }

    private void Start()
    {
        Attack1Button.GetComponentInChildren<TextMeshProUGUI>().text = player.AnimalPlayer.Attack1Name;
        Defense1Button.GetComponentInChildren<TextMeshProUGUI>().text = player.AnimalPlayer.Defense1Name;
        Attack2Button.GetComponentInChildren<TextMeshProUGUI>().text = player.WeaponPlayer.Attack1Name;

        Attack1Button.onClick.AddListener(() => player.AnimalAttack(enemy));
        Attack1Button.onClick.AddListener(EnemyChoose);

        Defense1Button.onClick.AddListener(player.AnimalDefense);
        Defense1Button.onClick.AddListener(EnemyChoose);

        Attack2Button.onClick.AddListener(() => player.WeaponAttack(enemy));
        Attack2Button.onClick.AddListener(EnemyChoose);

        FleeButton.onClick.AddListener(Flee);

        player.AnimalPlayer.UITextAnnouncement = ActionText;
        player.WeaponPlayer.UITextAnnouncement = ActionText;

        enemy.AnimalPlayer.UITextAnnouncement = ActionText;
        enemy.WeaponPlayer.UITextAnnouncement = ActionText;


        PAnimalImage.sprite = player.AnimalPlayer.AnimalImage;
        PWeaponImage.sprite = player.WeaponPlayer.WeaponImage;
        EAnimalImage.sprite = enemy.AnimalPlayer.AnimalImage;
        EWeaponImage.sprite = enemy.WeaponPlayer.WeaponImage;

        PlayerName.text = player.AnimalPlayer.AnimalName;
        EnemyName.text = enemy.AnimalPlayer.AnimalName;

        player.HealthImage = PlayerUI;
        enemy.HealthImage = EnemyUI;

        player.RemainingHealth = playerHealthText;
        player.TotalHealth = (int)player.AnimalPlayer.Health;

        enemy.TotalHealth = (int)enemy.AnimalPlayer.Health;

        player.UpdateUI(player);
        enemy.UpdateUI(enemy);

        if(player.AnimalPlayer.speed >= enemy.AnimalPlayer.speed)
        {
            //player goes first
        }
        else
        {
            EnemyChoose();
        }
    }

    public void Flee()
    {
       ActionText.text = string.Format("{0} is fleeing!", player.AnimalPlayer.AnimalName);
        TurnUIOffOrOn(false);

        GameManager.instance.Win = false;

        Scene.ChangeScene("EndScene");
    }

    public void TurnUIOffOrOn(bool OnOrOff)
    {
        if (OnOrOff)
        {
            Attack1Button.gameObject.SetActive(true);
            Attack2Button.gameObject.SetActive(true);
            Defense1Button.gameObject.SetActive(true);
            FleeButton.gameObject.SetActive(true);
        }
        else
        {
            Attack1Button.gameObject.SetActive(false);
            Attack2Button.gameObject.SetActive(false);
            Defense1Button.gameObject.SetActive(false);
            FleeButton.gameObject.SetActive(false);
        }

    }

    public void EnemyChoose()
    {

        TurnUIOffOrOn(false);
        bool GameOver = GameOverCheck();

        if (!GameOver)
        {
            StartCoroutine(EnemyTurn());
        }



    }

    public bool GameOverCheck()
    {
        if(player.AnimalPlayer.Health <= 0)
        {
            GameManager.instance.Win = false;
            Scene.ChangeScene("EndScene");
            return true;
        }

        if(enemy.AnimalPlayer.Health <= 0)
        {
            GameManager.instance.Win = true;
            Scene.ChangeScene("EndScene");
            return true;
        }

        return false;
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

        bool GameOver = GameOverCheck();
        if (!GameOver)
        {
            TurnUIOffOrOn(true);
        }
    }

    void UpdateHealthUI()
    {

    }
}

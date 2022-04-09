using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameBattleManager : MonoBehaviour
{

    public Button Attack1Button;
    public Button Defense1Button;
    public Button Attack2Button;
    public Button FleeButton;


    private void Start()
    {
        Attack1Button.GetComponentInChildren<TextMeshProUGUI>().text = GameManager.instance.playerClass.AnimalPlayer.Attack1Name;
        Defense1Button.GetComponentInChildren<TextMeshProUGUI>().text = GameManager.instance.playerClass.AnimalPlayer.Defense1Name;
        Attack2Button.GetComponentInChildren<TextMeshProUGUI>().text = GameManager.instance.playerClass.WeaponPlayer.Attack1Name;

        Attack1Button.onClick.AddListener(GameManager.instance.playerClass.AnimalAttack);
        Defense1Button.onClick.AddListener(GameManager.instance.playerClass.AnimalDefense);
        Attack2Button.onClick.AddListener(GameManager.instance.playerClass.WeaponAttack);
        FleeButton.onClick.AddListener(Flee);
    }

    public void Flee()
    {
        Debug.Log("FLeeing!!!");
    }

}

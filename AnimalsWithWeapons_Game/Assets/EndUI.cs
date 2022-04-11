using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndUI : MonoBehaviour
{
    public TextMeshProUGUI WinText, LoseText;

    // Start is called before the first frame update
    void Start()
    {
        WinText.gameObject.SetActive(false);
        LoseText.gameObject.SetActive(false);

        if(GameManager.instance.Win == true)
        {
            WinText.gameObject.SetActive(true);
        }
        else
        {
            LoseText.gameObject.SetActive(true);
        }
    }

}

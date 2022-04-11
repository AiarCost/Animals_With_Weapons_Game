using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{


    public void ChangeScene( int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ChangeSceneWithPlayerCheck(int SceneIndex)
    {
        if(GameManager.instance.playerClass != null && GameManager.instance.enemyClass != null)
        {
            SceneManager.LoadScene(SceneIndex);
        }
    }

    public void QuitFunction()
    {
        Application.Quit();
    }
}

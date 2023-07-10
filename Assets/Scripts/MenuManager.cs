using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void Level1() => SceneManager.LoadScene("IcyLevel");
    public void Level2() => SceneManager.LoadScene("TableSoccerLevel");
    public void Level3() => SceneManager.LoadScene("DiscLevel");

    public void QuitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
    }

    public void Update()
    {
        if (GameManager.playerScore == 5 || GameManager.opponentScore == 5)
        {
            SceneManager.LoadScene("Menu");
            GameManager.playerScore = 0;
            GameManager.opponentScore = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
            GameManager.playerScore = 0;
            GameManager.opponentScore = 0;
        }
    }
}

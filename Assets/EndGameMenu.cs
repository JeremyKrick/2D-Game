using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    public GameObject endGameMenuUI;

    public void Restart()
    {
        PrevKills.prevKills = KillsCounter.killsNumber;
        KillsCounter.killsNumber = 0;
        EnemyMovement.GameOver = false;
        endGameMenuUI.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }
    public void Menu()
    {
        PrevKills.prevKills = KillsCounter.killsNumber;
        KillsCounter.killsNumber = 0;
        EnemyMovement.GameOver = false;
        endGameMenuUI.SetActive(false);
        SceneManager.LoadScene("TitleScene");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyMovement.GameOver)
        {
            endGameMenuUI.SetActive(true);
        }
    }
}

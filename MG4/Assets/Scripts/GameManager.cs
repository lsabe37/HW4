using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Locator.Instance.player.gameOver += endGame;
    }

    public void endGame()
    {
        Time.timeScale = 0f;
    }

    public void retryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

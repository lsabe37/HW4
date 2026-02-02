using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text gameoverText;
    [SerializeField] private GameObject retryButton;
    private float currentPoints;
    private float highScorePoints;

    private void Start()
    {
        Locator.Instance.player.getPoint += updatePointsUI;
        Locator.Instance.player.gameOver += showGameOver;
        retryButton.gameObject.SetActive(false);
    }

    public void updatePointsUI()
    {
        currentPoints += 1;
        pointsText.text = "Points: " + currentPoints.ToString();
    }

    public void showGameOver()
    {
        gameoverText.gameObject.SetActive(true);
        retryButton.gameObject.SetActive(true);
    }
}

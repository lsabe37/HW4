using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text gameoverText;
    private float currentPoints;

    private void Start()
    {
        Locator.Instance.player.getPoint += updatePointsUI;
        Locator.Instance.player.gameOver += showGameOver;
    }

    public void updatePointsUI()
    {
        currentPoints += 1;
        pointsText.text = "Points: " + currentPoints.ToString();
    }

    public void showGameOver()
    {
        gameoverText.gameObject.SetActive(true);
    }
}

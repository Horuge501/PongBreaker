using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject playerGoal;

    [SerializeField] private GameObject computer;
    [SerializeField] private GameObject computerGoal;

    [SerializeField] private TextMeshProUGUI playerText;
    [SerializeField] private TextMeshProUGUI computerText;

    private int playerScore;
    private int computerScore;

    public void PlayerScore()
    {
        playerScore++;
        playerText.text = playerScore.ToString();
        ResetPosition();
    }

    public void ComputerScore()
    {
        computerScore++;
        computerText.text = computerScore.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player.GetComponent<PongMovement>().Reset();
        computer.GetComponent<Computer>().Reset();
    }
}

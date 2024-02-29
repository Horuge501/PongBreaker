using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool playerGoal;
    [SerializeField] private GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {

            if (playerGoal)
            {
                gameManager.GetComponent<GameManager>().PlayerScore();
            }
            else
            {
                gameManager.GetComponent<GameManager>().ComputerScore();
            }
        }
    }
}

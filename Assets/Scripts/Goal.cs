using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    public TMPro.TextMeshProUGUI Points1;
    public TMPro.TextMeshProUGUI Points2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored !!!");
                GameplayManager.Instance.PointsB++;
                GameplayManager.Instance.ResetPosition();
            }
            else
            {
                Debug.Log("Player 1 Scored !!!");
                GameplayManager.Instance.PointsA++;
                GameplayManager.Instance.ResetPosition();
            }
        }
    }

    public void Player1Points(int points)
    {
        Points1.text = "" + points;
    }

    public void Player2Points(int points)
    {
        Points2.text = "" + points;
    }
}

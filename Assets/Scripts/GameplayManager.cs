using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : Singleton<GameplayManager>
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Paddle")]
    public GameObject player1Paddle;
    public GameObject player2Paddle;

    private Goal goal;
    private int points1;
    private int points2;

    private void Start()
    {
        goal = FindObjectOfType<Goal>();
    }

    public int PointsA
    {
        get { return points1; }
        set
        {
            points1 = value;
            goal.Player1Points(points1);
        }
    }

    public int PointsB
    {
        get { return points2; }
        set
        {
            points2 = value;
            goal.Player2Points(points2);
        }
    }

    public void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}

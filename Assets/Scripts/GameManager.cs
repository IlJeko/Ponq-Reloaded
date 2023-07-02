using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int playerScore = 0;
    public static int opponentScore = 0;
    public static GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Score (string goalId)
    {
        if (goalId == "PlayerGoal")
        {
            playerScore++;
        }
        else
        {
            opponentScore++;
        }
    }
}

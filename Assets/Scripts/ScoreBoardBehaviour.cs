using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : MonoBehaviour
{
    public TextMeshProUGUI PlayerOneScoreText;
    public TextMeshProUGUI PlayerTwoScoreText;

    private int playerOneScore;
    private int playerTwoScore;

    void Update()
    {
        PlayerOneScoreText.text = playerOneScore.ToString();
        PlayerTwoScoreText.text = playerTwoScore.ToString();
    }

    public void PlayerScored(string tag)
    {
        if(tag == "Player1")
        {
            playerOneScore += 1;
        }
        else if(tag == "Player2")
        {
            playerTwoScore += 1;
        }
    }
}

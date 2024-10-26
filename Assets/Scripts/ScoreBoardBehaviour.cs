using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : MonoBehaviour
{
    public TextMeshProUGUI PlayerOneScoreText;
    public TextMeshProUGUI PlayerTwoScoreText;
    public AudioSource SoundEffect;

    private int playerOneScore;
    private int playerTwoScore;

    private bool PlayerOneOnAStreak;
    private bool PlayerTwoOnAStreak;

    void Update()
    {
        PlayerOneScoreText.text = playerOneScore.ToString();
        PlayerTwoScoreText.text = playerTwoScore.ToString();
    }

    public void PlayerScored(string tag)
    {
        SoundEffect.Play();
        if(tag == "Player1")
        {
            PlayerTwoOnAStreak = false;
            if(PlayerOneOnAStreak)
            {
                playerOneScore += 2;
            }
            playerOneScore += 1;
            PlayerOneOnAStreak = true;
        }
        else if(tag == "Player2")
        {
            PlayerOneOnAStreak = false;
            if(PlayerTwoOnAStreak)
            {
                playerTwoScore += 2;
            }
            playerTwoScore += 1;
            PlayerTwoOnAStreak = true;
        }
    }
}

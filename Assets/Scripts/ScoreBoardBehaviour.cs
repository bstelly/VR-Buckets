using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : RealtimeComponent<ScoreSyncModel>
{
    public TextMeshProUGUI PlayerOneScoreText;
    public TextMeshProUGUI PlayerTwoScoreText;
    public AudioSource SoundEffect;

    //private int playerOneScore;
    //private int playerTwoScore;

    private bool PlayerOneOnAStreak;
    private bool PlayerTwoOnAStreak;

    protected override void OnRealtimeModelReplaced(ScoreSyncModel previousModel, ScoreSyncModel currentModel)
    {
        if(currentModel != null)
        {
            if(currentModel.isFreshModel)
            {
                currentModel.playerOneScore = model.playerOneScore;
                currentModel.playerTwoScore = model.playerTwoScore;
            }
        }
    }

    void Update()
    {
        PlayerOneScoreText.text = model.playerOneScore.ToString();
        PlayerTwoScoreText.text = model.playerTwoScore.ToString();
    }

    public void PlayerScored(string tag)
    {
        SoundEffect.Play();
        if(tag == "Player1")
        {
            PlayerTwoOnAStreak = false;
            if(PlayerOneOnAStreak)
            {
                model.playerOneScore += 2;
            }
            else
            {
                model.playerOneScore += 1;
            }

            PlayerOneOnAStreak = true;
        }
        else if(tag == "Player2")
        {
            PlayerOneOnAStreak = false;
            if(PlayerTwoOnAStreak)
            {
                model.playerTwoScore += 2;
            }
            else
            {
                model.playerTwoScore += 1;
            }

            PlayerTwoOnAStreak = true;
        }
    }
}

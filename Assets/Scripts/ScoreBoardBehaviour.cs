using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Transactions;
using TMPro;
using UnityEngine;

public class ScoreBoardBehaviour : RealtimeComponent<ScoreSyncModel>
{
    public TextMeshProUGUI PlayerOneScoreText;
    public TextMeshProUGUI PlayerTwoScoreText;
    public AudioSource SoundEffect;

    //private int playerOneScore;
    //private int playerTwoScore;

    //private bool PlayerOneOnAStreak;
    //private bool PlayerTwoOnAStreak;

    protected override void OnRealtimeModelReplaced(ScoreSyncModel previousModel, ScoreSyncModel currentModel)
    {
        if (currentModel != null)
        {
            if (previousModel != null)
            {
                previousModel.playerOneScoreDidChange -= PlayerOneScoreChanged;
                previousModel.playerTwoScoreDidChange -= PlayerTwoScoreChanged;
            }
             
            if(currentModel.isFreshModel)
            {
                currentModel.playerOneScore = model.playerOneScore;
                currentModel.playerTwoScore = model.playerTwoScore;
                currentModel.playerOneOnAStreak = model.playerOneOnAStreak;
                currentModel.playerTwoOnAStreak = model.playerTwoOnAStreak;
            
                currentModel.playerOneScoreDidChange += PlayerOneScoreChanged;
                currentModel.playerTwoScoreDidChange += PlayerTwoScoreChanged;
            }
        }
    }

    void Update()
    {
        PlayerOneScoreText.text = model.playerOneScore.ToString();
        PlayerTwoScoreText.text = model.playerTwoScore.ToString();
        model.playerOneScoreDidChange += PlayerOneScoreChanged;
        model.playerTwoScoreDidChange += PlayerTwoScoreChanged;
    }

    private void PlayerOneScoreChanged(ScoreSyncModel model, int value)
    {
        SoundEffect.Play();
    }
    private void PlayerTwoScoreChanged(ScoreSyncModel model, int value)
    {
        SoundEffect.Play();
    }

    public void PlayerScored(string tag)
    {
        if(tag == "Player1")
        {
            model.playerTwoOnAStreak = false;
            if(model.playerOneOnAStreak)
            {
                model.playerOneScore += 2;
            }
            else
            {
                model.playerOneScore += 1;
            }

            model.playerOneOnAStreak = true;
        }
        else if(tag == "Player2")
        {
            model.playerOneOnAStreak = false;
            if(model.playerTwoOnAStreak)
            {
                model.playerTwoScore += 2;
            }
            else
            {
                model.playerTwoScore += 1;
            }

            model.playerTwoOnAStreak = true;
        }
    }
}

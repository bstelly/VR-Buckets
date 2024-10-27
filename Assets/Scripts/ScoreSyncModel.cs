using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

[RealtimeModel]
public partial class ScoreSyncModel
{
    [RealtimeProperty(1, true, true)]
    private int _playerOneScore;
    [RealtimeProperty(2, true, true)]
    private int _playerTwoScore;
    [RealtimeProperty(3, true, true)]
    private bool _playerOneOnAStreak;
    [RealtimeProperty(4, true, true)]
    private bool _playerTwoOnAStreak;
}

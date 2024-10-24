using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracking : MonoBehaviour
{
    public List<PlayerJoinedBehaviour> PlayersActive = new List<PlayerJoinedBehaviour>();
    
    public void PlayerJoined(PlayerJoinedBehaviour player)
    {
        PlayersActive.Add(player);
        var newTag = "Player" + PlayersActive.Count.ToString();
        player.gameObject.tag = newTag;
    }
}

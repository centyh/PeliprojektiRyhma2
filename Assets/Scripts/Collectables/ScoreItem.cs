using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : ItemBase
{
   
    public override void OnCollect(PlayerData playerData)
    {
        playerData.score += (int)value;
        Debug.Log("Score increased by " + value);
        Destroy(gameObject);
        
    }
}

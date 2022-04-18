using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        
        // Add up score and show it
        ScoreLivesLog.score += ScoreLivesLog.valueScore;
        Debug.Log($"Score = {ScoreLivesLog.score}");
    }
}

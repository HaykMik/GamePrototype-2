using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Cookie")) 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            ScoreLivesLog.score++;
            Debug.Log($"Score = {ScoreLivesLog.score}");
        }
        else if (gameObject.CompareTag("Player"))
        {
            ScoreLivesLog.lives--;
            Debug.Log($"Lives = {ScoreLivesLog.lives}");
        }

        if (ScoreLivesLog.lives < 1)
        {
            Debug.Log("Game Over!");
            Debug.Log($"Lives = {ScoreLivesLog.lives}");
        }
        else
        {
            Debug.Log($"Score = {ScoreLivesLog.score}");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}

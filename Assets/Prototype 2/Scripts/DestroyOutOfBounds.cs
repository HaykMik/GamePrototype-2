using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    private float sidesBound = 30;

    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            if (ScoreLivesLog.lives >= 2)
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
            } else
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
                Debug.Log("Game Over!");
            }
        }

        if (transform.position.x > sidesBound)
        {
            Destroy(gameObject);
            if (ScoreLivesLog.lives >= 2)
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
            }
            else
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
                Debug.Log("Game Over!");
            }
        }

        if (transform.position.x < -sidesBound)
        {
            Destroy(gameObject);
            if (ScoreLivesLog.lives >= 2)
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
            }
            else
            {
                ScoreLivesLog.lives--;
                Debug.Log($"Lives = {ScoreLivesLog.lives}");
                Debug.Log("Game Over!");
            }
        }
    }
}

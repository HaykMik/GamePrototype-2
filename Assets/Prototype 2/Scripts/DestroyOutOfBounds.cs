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
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        if (transform.position.x > sidesBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        if (transform.position.x < -sidesBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

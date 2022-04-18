using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLivesLog : MonoBehaviour
{
    internal static int score;
    internal static int valueScore = 1;
    internal static int lives = 3;

    public void Start()
    {
        Debug.Log($"Lives = {lives}");
        Debug.Log($"Score = {score}");
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (lives >= 2)
        {
            lives--;
            Debug.Log($"Lives = {lives}");
        } else
        {
            lives--;
            Debug.Log($"Lives = {lives}");
            Debug.Log("Game Over!");
        }
    }
}

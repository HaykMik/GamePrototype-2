using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float time = 1f;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        // Delay for pressing space bar (do not spam)
        timer += Time.deltaTime;
        if (timer >= time)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0;
            }
        }
    }
}

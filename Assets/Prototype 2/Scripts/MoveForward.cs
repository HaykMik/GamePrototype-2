using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40f;

    void Update()
    {
        if (transform.position.x == 27f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        } else if (transform.position.x == -27)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        } else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}

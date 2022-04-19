using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<HungerBar>().FeedAnimal(1);
        Destroy(gameObject);
    }
}

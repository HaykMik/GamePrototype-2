using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            ScoreLivesLog.score++;
            Destroy(gameObject, 0.1f);
        }

    }
}

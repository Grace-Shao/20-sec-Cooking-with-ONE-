using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 20f;

    // same as private but we can see it in field
    [SerializeField] TextMeshProUGUI countdownText;

    private void Awake()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        if (currentTime >= 0)
        {
            countDown();
        }
    }

    private void countDown()
    {
        // time.deltaTime The interval in seconds from the last frame to the current one 
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
    }
}

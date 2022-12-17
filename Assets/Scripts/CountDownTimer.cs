using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 20f;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        // time.deltaTime The interval in seconds from the last frame to the current one 
        currentTime -= 1 * Time.deltaTime;

    }
}

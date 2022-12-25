using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingsManager : MonoBehaviour
{
    // https://youtu.be/TWxXD-UpvSg good link on unity events

    // Update is called once per frame
    void Update()
    {
        // normal ending
        if (CountDownTimer.currentTime < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        // good ending
        if (DetectFire.burntLevel < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //if everything catches on fire, bad ending...
        if (GameObject.FindWithTag("MediumFire") != null && CountDownTimer.currentTime < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}

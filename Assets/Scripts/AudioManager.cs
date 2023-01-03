using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Information")]

    [SerializeField] private AudioSource audio;

    // ensure only one audioManager (don't destroy current manager)
    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        // if audio manager doesn't exists, manager to itself, else destroy old audio mangers.
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        audio.loop = true;
        audio.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFire : MonoBehaviour
{
    // Start is called before the first frame update
    static public float burntLevel = 100; // change to private later but static global variable works for now
    [SerializeField] private float burnStrength;

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("particle collision");
        burntLevel -= burnStrength * Time.deltaTime;
        Debug.Log(burntLevel);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFire : MonoBehaviour
{
    // Start is called before the first frame update
    static public float burntLevel; // change to private later but static global variable works for now
    [SerializeField] private float burnStrength;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("particle collision");
        burntLevel -= burnStrength * Time.deltaTime;
        Debug.Log(burntLevel);
    }
}

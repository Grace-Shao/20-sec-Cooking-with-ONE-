using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float burntLevel;
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

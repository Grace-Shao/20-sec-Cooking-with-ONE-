using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFire : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float burntLevel;

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
        burntLevel -= 1;
        Debug.Log(burntLevel);
    }
}

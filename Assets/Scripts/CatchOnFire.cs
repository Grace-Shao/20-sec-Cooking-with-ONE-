using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchOnFire : MonoBehaviour
{
    [SerializeField] private GameObject mediumFlame;
    bool hasFire = false;

    private void OnParticleCollision(GameObject other)
    {
        if (!hasFire)
        {
            // attach a flame effect on it
            Instantiate(mediumFlame, transform.position, Quaternion.identity);
        }
    }
}

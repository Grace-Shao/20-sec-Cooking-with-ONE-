using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillAction : MonoBehaviour
{
    public GameObject flameThrower;
    void OnEnable()
    {
        EventManager.onGrill += Grilling;
    }

    void OnDisable()
    {
        EventManager.onGrill -= Grilling;
    }

    void Grilling()
    {
        // if flamethrower is active, turn it off. else turn it on
        if(flameThrower.activeSelf)
        {
            flameThrower.SetActive(false);
        } else
        {
            flameThrower.SetActive(true);
        }
    }

}

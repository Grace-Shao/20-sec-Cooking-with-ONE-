using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrillAction : MonoBehaviour
{
    public GameObject flameThrower;
    void OnEnable()
    {
        EventManager.onChop += Grilling;
    }

    void OnDisable()
    {
        EventManager.onChop -= Grilling;
    }

    void Grilling()
    {
        flameThrower.SetActive(true);
    }

}

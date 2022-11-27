using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopAction : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.onChop += Chopping;
    }

    void OnDisable()
    {
        EventManager.onChop -= Chopping;
    }

    void Chopping()
    {
        Debug.Log("Chopping event");
    }
}

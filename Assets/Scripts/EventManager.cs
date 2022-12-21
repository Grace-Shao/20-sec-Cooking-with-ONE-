using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ActivateChopAction();
    public static event ActivateChopAction onChop;

    public delegate void ActivateGrillAction();
    public static event ActivateChopAction onGrill;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Clicked R for onChop");
            if (onChop != null)
            {
                onChop();
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Clicked G for onGrill");
            if (onGrill != null)
            {
                onGrill();
            }
        }
    }
}

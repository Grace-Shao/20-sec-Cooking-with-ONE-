using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ActivateChopAction();
    public static event ActivateChopAction onChop;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Clicked");
            if (onChop != null)
            {
                onChop();
            }
        }
    }
}

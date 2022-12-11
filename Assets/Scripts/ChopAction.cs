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
        GameObject player = GetComponent<GameObject>();
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Trigger");
        //GameObject player = GetComponent<GameObject>();
        //Transform transform = GetComponent<GameObject>().transform;
        foreach (Transform child in transform.GetComponentsInChildren<Transform>())
        {
            if(child.CompareTag("Tomato"))
            {
                Debug.Log("Close to chopping and are holding a tomato");
            }
        }
        /*foreach (Transform child in transform)
        {
            if (child.tag == "Tomato")
            {
                Debug.Log("Tomato obtained");
            }
        }*/
        /*if (GetComponentInChildren<GameObject>().CompareTag("Tomato"))
        {
            Debug.Log("Tomato obtained");
        }*/
    }
}

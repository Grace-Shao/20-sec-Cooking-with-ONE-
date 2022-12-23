using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopAction : MonoBehaviour
{
    [SerializeField] private GameObject tomatoSlices; // may be bad programming
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
        GameObject cuttingBoard = GameObject.FindGameObjectWithTag("CuttingBoard");
        Transform tomato = null;
        Transform tomatoSpotOnBoard = null;
        Vector3 playerPosition = GetComponent<Transform>().position;
        float distance = 0;
        float playerToCuttingBoardRange = 2f;
       
        // find the tomato's position
        foreach (Transform child in transform.GetComponentsInChildren<Transform>())
        {
            if (child.CompareTag("Tomato"))
            {
                tomato = child;
            }
        }
        // and there is a tomato in hannddd
        if (cuttingBoard != null && tomato != null)
        {
            distance = (playerPosition - cuttingBoard.transform.position).magnitude;
            Debug.Log("distance" + distance);
            if (distance < playerToCuttingBoardRange)
            {
                // put the tomato on top of the board
                Debug.Log("Will put tomato on board");
                // first child is the pos spot
                tomatoSpotOnBoard = cuttingBoard.transform.GetChild(0);
                tomato.parent = tomatoSpotOnBoard;
                tomato.position = tomatoSpotOnBoard.position;
                // 1 second wait after destroy (can only destroy game obj, not transform)
                Object.Destroy(tomato.gameObject, 1);
                Instantiate(tomatoSlices, tomatoSpotOnBoard.transform.position, Quaternion.identity); // may be bad programming
                
                // cant chop again
                OnDisable();
            }
        }

        // if player is near kitchen, chop it

        // for each obj in transform, get thaat tomato
        // Destroy the prefab and replace it with a chopped one
    }


    // a callback function unity calls itself, u dont actually call it
    // Use OnDrawGizmosSelected to draw gizmos when the game object is selected.
    // boxcast raycast

    //void OnDrawGizmos()
    //{
    //    float maxDistance = 10f;
    //    RaycastHit hit;

    //    bool isHit = Physics.BoxCast(transform.position, transform.lossyScale / 2, transform.forward, out hit,
    //            transform.rotation, maxDistance);

    //    if (isHit)
    //    {
    //        Gizmos.color = Color.red;
    //        Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
    //        Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.lossyScale);
    //        Debug.Log("Kitchen detected");
    //    } 
    //    else
    //    {
    //        Debug.Log("Kitchen not detected");

    //        Gizmos.color = Color.green;
    //        Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
    //    }
    //}

    //private void OnTriggerEnter(Collider collision)
    //{
    //    Debug.Log("Trigger");
    //    //GameObject player = GetComponent<GameObject>();
    //    //Transform transform = GetComponent<GameObject>().transform;
    //    foreach (Transform child in transform.GetComponentsInChildren<Transform>())
    //    {
    //        if(child.CompareTag("Tomato"))
    //        {

    //            Debug.Log("Close to chopping and are holding a tomato");
    //        }
    //    }
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
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    //public Rigidbody rb;
    [SerializeField] private BoxCollider coll;
    [SerializeField] private Transform player, itemContainer;

    [SerializeField] private float pickupRange;
    [SerializeField] private float dropForwardForce, dropUpwardForce;

    [SerializeField] private bool equipped;
    // Start is called before the first frame update
    void Update()
    {
        // Check if player is in range and "E" is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickupRange && Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Picked up");
            Pickup();
        }

        // Drop if equipped and "Q" is pressed
        if (equipped && Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }
    }

    private void Pickup()
    {
        // if itemcontainer alr has an object, "drop the item"
        if (itemContainer.childCount > 0)
        {
            return;
        } 
        else
        {
            equipped = true;

            // make weapon a chold of the camera and move it to the default position
            transform.SetParent(itemContainer);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(Vector3.zero);

            // make rigidBody kinematic (so item doesn't move anymore) and BoxCollider a trigger
            //rb.isKinematic = true;
            //rb.detectCollisions = false;
            coll.isTrigger = true;
        }
        
    }

    // why does boxCollider need to be a trigger
    private void Drop()
    {
        equipped = false;

        // set parent to null (parent used to be itemContainer)
        transform.SetParent(null);

        // make rigidBody not kinematic and BoxCollider normal
        //rb.isKinematic = false;
        //rb.detectCollisions = true;
        coll.isTrigger = false;
    }
}

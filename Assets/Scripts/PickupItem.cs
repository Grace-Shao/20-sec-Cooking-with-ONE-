using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    // should these all be public?
    //public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, itemContainer;

    public float pickupRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    // Start is called before the first frame update
    void Update()
    {
        // Check if player is in range and "E" is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickupRange && Input.GetKeyDown(KeyCode.E) && !slotFull)
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
        equipped = slotFull = true;

        // make weapon a chold of the camera and move it to the default position
        transform.SetParent(itemContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);

        // make rigidBody kinematic (so item doesn't move anymore) and BoxCollider a trigger
        //rb.isKinematic = true;
        //rb.detectCollisions = false;
        coll.isTrigger = true;
    }

    // why does boxCollider need to be a trigger
    private void Drop()
    {
        equipped = slotFull = false;

        // set parent to null (parent used to be itemContainer)
        transform.SetParent(null);

        // make rigidBody not kinematic and BoxCollider normal
        //rb.isKinematic = false;
        //rb.detectCollisions = true;
        coll.isTrigger = false;
    }
}

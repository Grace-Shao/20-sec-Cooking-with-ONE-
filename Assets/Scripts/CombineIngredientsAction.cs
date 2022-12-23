using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// similar to the chop action but uses serializable field (is this good better programming practice
// or chop actions?

public class CombineIngredientsAction : MonoBehaviour
{
    [SerializeField] private Transform plate;
    void OnEnable()
    {
        EventManager.onCombineIngredients += Combine;
    }

    void OnDisable()
    {
        EventManager.onCombineIngredients -= Combine;
    }

    void Combine()
    {
        Vector3 playerPosition = GetComponent<Transform>().position;
        float playerToPlateRange = 2f;
        float distance = (playerPosition - plate.position).magnitude;

        // if close to plate
        if (distance < playerToPlateRange)
        {

        }
        
        // if child one has tomato or cheese, put tomato or cheese on plate but child 2 is empty
        //      if child 1 has the other ingredient, combine to make pizza
        // if both child one and child two have things in them, being near plate will make pizza

    }
}

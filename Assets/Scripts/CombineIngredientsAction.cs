using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// similar to the chop action but uses serializable field (is this good better programming practice
// or chop actions?

public class CombineIngredientsAction : MonoBehaviour
{
    [SerializeField] private Transform plate;
    [SerializeField] private Transform itemContainer;
    [SerializeField] private Transform pizza;

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
        // access the first child
        Transform foodContainer = plate.GetChild(0);

        // if close to plate (only things that u can pick up is tomato and cheese so picking those up is satisfied)
        if (distance < playerToPlateRange)
        {
            // if plate has nothing in it's contain, put that child obj into the container
            if (foodContainer.childCount == 0)
            {
                itemContainer.GetChild(0).position = foodContainer.position;
                itemContainer.GetChild(0).parent = foodContainer;
            }
            else // if plate alr has something in it's container, transform into pizza
            {
                Object.Destroy(itemContainer.GetChild(0).gameObject); // destroy the ingrdients
                Object.Destroy(foodContainer.GetChild(0).gameObject);
                Instantiate(pizza, itemContainer.transform.position, Quaternion.identity);
            }         
        }

        // if the plate has pizza, disable the combine action


    }
}

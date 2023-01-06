using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ActivateChopAction();
    public static event ActivateChopAction onChop;

    public delegate void ActivateCombineIngredientsAction();
    public static event ActivateCombineIngredientsAction onCombineIngredients;

    public delegate void ActivateGrillAction();
    public static event ActivateChopAction onGrill;

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject itemContainer;

    void Update()
    {
        // can only chop once bc chop event unsubscribes
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (onChop != null)
            {
                Debug.Log("Clicked R for onChop");
                onChop();
            }
        }
        // combine ingredients action
        // if the first child is a tomato or a cheese, combine ingredients
        if (Input.GetKeyDown(KeyCode.A)) // r is the generic grab
        {
            if(itemContainer.transform.childCount > 0)
            {
                Transform child1 = itemContainer.transform.GetChild(0);
                if (child1.CompareTag("TomatoSlices") || child1.CompareTag("Cheese")) // and near a plate later
                {
                    if (onCombineIngredients != null)
                    {
                        Debug.Log("Ingredients combined!");
                        onCombineIngredients();
                    }
                    
                }
            }
        }
            

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (onGrill != null)
            {
                Debug.Log("Clicked G for onGrill");
                onGrill();
            }
        }
    }

    // after everything is done, make 3 ending scenes
}

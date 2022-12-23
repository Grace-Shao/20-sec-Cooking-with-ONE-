using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineIngredientsAction : MonoBehaviour
{
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

    }
}

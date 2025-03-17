using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Interactions;

public class ColorChanger : MonoBehaviour, IInteractable
{

    Material mat;

    private void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }

    public string GetDescription()
    {
        return "Change to a random colour";
    }

    public void Interact()
    {
        mat.color = new Color(Random.value, Random.value, Random.value);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour
{
    bool isCompleted;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (GetKeyUp(KeyCode.E))
        {
        // Get the objects involved in the collision
        GameObject parentObject = collision.gameObject;
        GameObject childObject = gameObject;

        // Set the parent of the child object
        childObject.transform.SetParent(parentObject.transform);
        Debug.Log("Object is now a child of " + parentObject.name);
        }

    }

    void Trash()
    {
        Debug.Log("Picled up trash!");

    }
}

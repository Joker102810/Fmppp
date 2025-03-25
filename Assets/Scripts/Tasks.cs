using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    public Canvas interact;
    public float radius;
    bool isCompleted;
    void Start()
    {
        interact.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius);
        if (hit != null)
        {
            interact.enabled = true;
            Debug.Log("Hit something: " + hit.gameObject.name);
            PickUp(hit.GetComponent<Collider>());
        }
        else
        {
            interact.enabled = false;
        }

        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            Unparenting();
        }
        */
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(" WOWWWWW");
        if (Input.GetKeyDown(KeyCode.E))
        {

            // Get the objects invoved in the collision
            GameObject childObject = collision.gameObject;
            GameObject parentObject = gameObject;

            // Set the parent of the child object
            childObject.transform.SetParent(parentObject.transform);
            Debug.Log("Object is now a child of " + parentObject.name);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(" key pressed!");
            GameObject childObject = collision.gameObject;
            GameObject parentObject = gameObject;

            childObject.transform.SetParent(null);
            Debug.Log("Object is no longer a child of " + parentObject.name);
        }

    }

    void Unparenting()
    {
        Transform parent = transform.parent;
        if (transform.parent != null)
        {
            transform.parent = null;
            Debug.Log("Object is no longer a child of " + parent.name);
        }
    }

    void Trash()
    {
        Debug.Log("Picled up trash!");

    }

    public void PickUp(Collision2D collision)
    {

      
          Debug.Log(" WOWWWWW");
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            // Get the objects invoved in the collision
            GameObject childObject = collision.gameObject;
            GameObject parentObject = gameObject;

            // Set the parent of the child object
            childObject.transform.SetParent(parentObject.transform);
            Debug.Log("Object is now a child of " + parentObject.name);
        }
         if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(" key pressed!");
            GameObject childObject = collision.gameObject;
            GameObject parentObject = gameObject;

            childObject.transform.SetParent(null);
            Debug.Log("Object is no longer a child of " + parentObject.name);
         }
       


        Debug.Log("Picked up!");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Tasks : MonoBehaviour
{
    Canvas interact;
    public float radius;
    bool isCompleted;
    bool PickedUpTrash;
    bool ThrownOutTrash;
   

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PickUp();
        
       
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
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

    public void PickUp() 
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D coll in hit)
        {
            if (hit != null && !coll.gameObject.CompareTag("Player"))
            {
                {
                    
                    //Debug.Log("Hit something: " + coll.gameObject.name);
                    if (Input.GetKeyDown(KeyCode.E))
                    {

                        // Get the objects invoved in the collision
                        GameObject childObject = coll.gameObject;
                        GameObject parentObject = gameObject;

                        // Set the parent of the child object
                        childObject.transform.SetParent(parentObject.transform);
                        Debug.Log("Object is now a child of " + parentObject.name);
                    }
                    if (Input.GetKeyDown(KeyCode.Q))
                    {
                        Debug.Log(" key pressed!");
                        GameObject childObject = coll.gameObject;
                        GameObject parentObject = gameObject;

                        childObject.transform.SetParent(null);
                        Debug.Log("Object is no longer a child of " + parentObject.name);
                    }
                }
            }
        }
    }

    void TakeOutTrash()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radius);
        {
            foreach (Collider2D coll in hit)
            {
                if (hit != null && !coll.gameObject.CompareTag("item"))
                {
                    GameObject.Destroy(coll.gameObject);
                }
            }
        }

    }

    

public class Task
    {
        // Public properties with getter and private setter
        public string TaskName { get; private set; }
        public string Description { get; private set; }
        public bool IsComplete { get; private set; }
        public Action OnComplete { get; private set; }

        // Constructor to initialize properties
        public Task(string taskName, string description, Action onComplete)
        {
            TaskName = taskName;
            Description = Description;
            IsComplete = false;
            OnComplete = onComplete;
        }

        // Method to mark the task as complete
        public void CompleteTask()
        {
            if (!IsComplete)
            {
                IsComplete = true;
                // Invoke the action when the task is completed
                OnComplete?.Invoke();
            }
        }
    }



}

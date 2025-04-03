using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TaskManager : MonoBehaviour
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
        TrashCan();


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

    public void TrashCan()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D coll in hit)
        {
            if (hit != null && coll.gameObject.CompareTag("Trash"))
            {
                {

                    
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("Minigame1");
                        Debug.Log("Minigame1");
                    }
                    if (Input.GetKeyDown(KeyCode.E) && (SceneManager.GetActiveScene().name == "Minigame1"))
                    {
                        SceneManager.LoadScene("Main Scene");
                        Debug.Log("Back to Main Scene");
                    }

                }
            }
        }
    }

}




using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class TaskManager : MonoBehaviour
{
    public Canvas interact;
    public float radius;
    bool isCompleted;
    bool PickedUpTrash;
    bool ThrownOutTrash;




    void Start()
    {
        interact.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TrashCan();
        TrashDone();

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
                }
            }
        }
    }
    
    public void TrashDone()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D coll in hit)
        {
            if (hit != null && coll.gameObject.CompareTag("Trash"))
            {
                if (Input.GetKeyDown(KeyCode.E) && (SceneManager.GetActiveScene().name == "Minigame1"))
                {
                    interact.gameObject.SetActive(true);                 
                    Invoke("MainScene", 3f);
                }
            }
        }

    }

    private void MainScene()
    {
        SceneManager.LoadScene("Main Scene");
        Debug.Log("Back to Main Scene");
    }
      
}




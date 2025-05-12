using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleaning : MonoBehaviour
{
    public string targetTag;
    public string nextSceneName; 

    private int objectsLeft; 

    void Start()
    {
        // Count the number of objects with the target tag in the scene
        objectsLeft = GameObject.FindGameObjectsWithTag(targetTag).Length;
        Debug.Log("Objects left: " + objectsLeft);
    }

    void Update()
    {
        // Check if the player has clicked the mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // Get the object under the cursor position
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            // Check if the ray hits an object with the target tag
            if (hit.collider != null && hit.collider.CompareTag(targetTag))
            {
                // Destroy the object
                Destroy(hit.collider.gameObject);
                Debug.Log("Object destroyed!");
                objectsLeft--;
                Debug.Log("Objects left: " + objectsLeft);

                // Check if there are no more objects left
                if (objectsLeft == 0)
                {
                    // Load the next scene
                    SceneManager.LoadScene("GoodEnd");
                    Debug.Log("Loading next scene...");
                }
            }
        }
    }
}
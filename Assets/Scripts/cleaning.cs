using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cleaning : MonoBehaviour
{
    public string targetTag; // The tag of the objects to destroy
    public string nextSceneName; // The name of the next scene to load

    private int objectsLeft; // The number of objects with the target tag left in the scene

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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits an object with the target tag
            if (Physics.Raycast(ray, out hit) && hit.transform.CompareTag(targetTag))
            {
                // Destroy the object
                Destroy(hit.transform.gameObject);
                Debug.Log("Object destroyed!");
                objectsLeft--;
                Debug.Log("Objects left: " + objectsLeft);

                // Check if there are no more objects left
                if (objectsLeft == 0)
                {
                    // Load the next scene
                    SceneManager.LoadScene(nextSceneName);
                    Debug.Log("Loading next scene...");
                }
            }
        }
    }
}
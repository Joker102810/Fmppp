using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public GameObject lights; // Assign your free form light in the inspector
    public Camera mainCamera; // Assign your main camera in the inspector

    void Update()
    {
        // Get the cursor position on the screen
        Vector2 cursorPosition = Input.mousePosition;

        // Convert the cursor position to a 3D point in world space
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(cursorPosition.x, cursorPosition.y, mainCamera.nearClipPlane));

        // Update the light's position
        lights.transform.position = worldPosition;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component

    private int direction = 0; // Current direction (0 = idle, 1 = up, 2 = down, 3 = left, 4 = right)

    void Update()
    {
        // Determine the direction the player is moving
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput > 0)
        {
            direction = 3; // Moving right
        }
        else if (horizontalInput < 0)
        {
            direction = 4; // Moving left
        }
        else if (verticalInput > 0)
        {
            direction = 1; // Moving up
        }
        else if (verticalInput < 0)
        {
            direction = 2; // Moving down
        }
        else
        {
            direction = 0; // Idle
        }

        // Set the animation based on the direction
        animator.SetInteger("Direction", direction);
    }
}
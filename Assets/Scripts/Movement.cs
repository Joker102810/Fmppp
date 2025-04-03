using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;

    private PlayerAnimationController playerAnimationController;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimationController = GetComponent<PlayerAnimationController>(); // Get the PlayerAnimationController script
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        rb.velocity = movement * speed;

        Flip(horizontal);

        // Play animations based on horizontal movement
        if (horizontal != 0)
        {
            if (horizontal < 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                playerAnimationController.PlayAnimation("WalkLeft");

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                playerAnimationController.PlayAnimation("WalkLeft");
            }
        }
        else
        {
            playerAnimationController.StopAnimation("Walk"); // Stop the walk animation when not moving horizontally
        }
    }

    private void Flip(float horizontal)
    {
        /*if (horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);   
        }*/


    }

    private void Flips(float vertical)
    {
        /*if (Vertical < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Vertical > 0)
        {
            transform.rotation = Quaternion.Euler(180, , 0);   
        }*/
    }
}
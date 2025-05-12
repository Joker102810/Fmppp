using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    private PlayerAnimationController playerAnimationController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimationController = GetComponent<PlayerAnimationController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        rb.velocity = movement * speed;

        Flip(horizontal);

        // Animation logic
        if (vertical > 0)
        {
            playerAnimationController.TransitionToState("Backwards");
        }
        else if (vertical < 0)
        {
            playerAnimationController.TransitionToState("Forward");
        }
        else if (horizontal > 0)
        {
            playerAnimationController.TransitionToState("Right");
        }
        else if (horizontal < 0)
        {
            playerAnimationController.TransitionToState("Left");
        }
        else
        {
            playerAnimationController.TransitionToState("Idle");
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
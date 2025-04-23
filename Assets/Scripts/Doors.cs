using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // The door's trigger collider
    public Collider2D triggerCollider;

    // The door's target position
    public Transform targetPosition;

    // The player's Rigidbody2D
    private Rigidbody2D playerRigidbody;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player entered the door's trigger area
        if (other.gameObject.CompareTag("Player"))
        {
            // Move the player to the target position
            playerRigidbody.MovePosition(targetPosition.position);
        }
    }

    void Start()
    {
        // Find the player's Rigidbody2D
        playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
}
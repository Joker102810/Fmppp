using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private const string PLAYER_TAG = "Player";

    void Start()
    {
        player = GameObject.Find(PLAYER_TAG);
        Debug.Log("Player found: " + player);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected!");
        if (collision.gameObject.CompareTag(PLAYER_TAG))
        {
            Debug.Log("Player collided!");
            NpcInteraction();
        }
    }

    private void NpcInteraction()
    {
        Anxiety anxiety = player.GetComponent<Anxiety>();
        if (anxiety != null)
        {
            Debug.Log("Panic method called!");
            anxiety.panic();
        }
        else
        {
            Debug.Log("Anxiety component not found!");
        }
    }
}

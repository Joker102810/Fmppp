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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision detected!");
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

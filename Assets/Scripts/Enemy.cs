using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private const string PLAYER_TAG = "Player";


    Vector3 pointA = new Vector3(59.2f, -4.1f, 0);
    Vector3 pointB = new Vector3(35.1f, -4.1f, 0);



    public float speed = 1f;

    
    int direction = 1;

    void Start()
    {
        player = GameObject.Find(PLAYER_TAG);
        Debug.Log("Player found: " + player);
    }

    private void Update()
    {
      
        Vector3 targetPosition = direction == 1 ? pointB : pointA;

       
        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);

        
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            
            direction *= -1;
        }
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

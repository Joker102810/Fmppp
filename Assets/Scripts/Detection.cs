using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public float radius = 1.5f;
    private GameObject Player;

    void Start()
    {
        
    }
void OnDrawGizmos()
{
    Gizmos.color = Color.red;
    Gizmos.DrawWireSphere(transform.position, radius);
}
    // Update is called once per frame
    void Update()
    {

        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius);
        if (hit != null)
        {
            Anxiety anxiety = Player.GetComponent<Anxiety>();
            if (anxiety != null)
            {
                Debug.Log("Panic method called!");
                anxiety.panic();
            }
            else
            {
                Debug.Log("Anxiety component not found!");
            }
            Debug.Log("Hit something: " + hit.gameObject.name);
        }
    }
}

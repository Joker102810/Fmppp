using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        gameobject = GameObject.Find("Player");
    }

    private void OnCollisionEnter(Collision collision)
    {
 if (collision.gameObject.tag == "Player")
        {
            NpcInteraction();
            Debug.Log("Collision");
        }
    }

    private void NpcInteraction()
    {
        GameObject Player = GameObject.Find("Player");
        Anxiety anxiety = Player.GetComponent<Anxiety>();
        if (anxiety != null)
        {
            anxiety.panic();
        }
    }
}

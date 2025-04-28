using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashCan : MonoBehaviour
{
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TrashAction();
    }

    public void TrashAction()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D coll in hit)
        {
            if (hit != null && coll.gameObject.CompareTag("Trash"))
            {
                {


                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        SceneManager.LoadScene("Minigame1");
                        Debug.Log("Minigame1");
                    }
                }
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Anxiety : MonoBehaviour
{
    public float mentality;
    public float maxMental = 1f;
    public Slider Slider;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
        mentality = maxMental;
        Slider.maxValue = maxMental;
        Slider.value = mentality;

        // Call LowerMentality every second
        InvokeRepeating("LowerMentality", 1f, 1f);
        Debug.Log("mentality is draining");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowerMentality()
    {
        Slider.value = mentality;
        mentality -= 0.1f;

        if(mentality <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }


    public void IncreaseMentality()
    {
        mentality += 3f;
        Slider.value = mentality;   
    }

    public void panic()
    {
        mentality -= 1f;
        Slider.value = mentality;
    }

}


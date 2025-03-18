using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anxiety : MonoBehaviour
{
    public float mentality;
    public float maxMental = 1000;
    public Slider Slider;

    // Start is called before the first frame update
    void Start()
    {
        mentality = maxMental;
        Slider.maxValue = maxMental;
        Slider.value = mentality;

        // Call LowerMentality every second
        InvokeRepeating("LowerMentality", 1f, 1f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowerMentality()
    {
        mentality -= 0.1f;
        Slider.value = mentality; 

        if(mentality <= 0)
        {
            //Destroy(gameObject);
        }
    }

    public void mentalDecline()
    { 
        mentality = 0; 
    }


}


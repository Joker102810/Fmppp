using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anxiety : MonoBehaviour
{
    public int mentality;
    public int maxMental = 10;
    public Slider Slider;

    // Start is called before the first frame update
    void Start()
    {
        mentality = maxMental;
        Slider.maxValue = maxMental;
        Slider.value = mentality;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowerMentality(int amount)
    {
        mentality -= amount;
        Slider.value = mentality;

        if(mentality <= 0)
        {
            Destroy(gameObject);
        }

    }

     


}


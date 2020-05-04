using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderFix : MonoBehaviour
{

    public Slider mainSlider;

    private void Update()
    {
        if(!TimerScript.IsStarted)
        {
            mainSlider.value = 0.5f;
        }
    }
}

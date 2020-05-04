using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class singleScript : MonoBehaviour
{
    public Slider mainSlider;

    public static bool IsNewRecord;

    private void Start()
    {
        IsNewRecord = false;
    }

    private void Update()
    {
        if (mainSlider.value == 0.0f || mainSlider.value == 1.0f)
        {
            TimerScript.IsStarted = false;
            float temp = TimerScript.timePassed;

            if(temp > recordSystem.LoadRecord())
            {
                recordSystem.SaveRecord(temp);
                IsNewRecord = true;
            }
            SceneManager.LoadScene("singleEnd");
            
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text time;

    public static bool IsStarted = false;
    
    public static float timePassed;
    int i = 0;
    private void Start()
    {
        timePassed = 0.0f;
    }

    private void FixedUpdate()
    {
        timePassed += 0.02f;

        if(timePassed >= 4.0f)
        {
            IsStarted = true;
        }

        else if(!IsStarted)
        {
            if(InRange(0.0f))
            {
                time.text = "3";
            }

            else if(InRange(1.0f))
            {
                time.text = "2";
            }
            else if (InRange(2.0f))
            {
                time.text = "1";
            }
            else if (InRange(3.0f))
            {
                time.text = "0";
            }
        }


        if (IsStarted)
        {
            if(i == 0)
            {
                Start();
            }
            i++;
            string timeStr = Convert.ToString(timePassed);
            try 
            {
                time.text = $"{timeStr[0]}{timeStr[1]}{timeStr[2]}{timeStr[3]}"; 
            }
            catch(Exception)
            {
                try
                {
                    time.text = $"{timeStr[0]}{timeStr[1]}{timeStr[2]}";
                }
                catch (Exception)
                {
                    time.text = $"{timeStr[0]}";
                }                
            }            
        }
    }

    bool InRange(float value)
    {
        bool res = false;

        if(value >= timePassed - 0.2f && value <= timePassed + 0.2f)
        {
            res = true;
        }

        return res;
    }
}



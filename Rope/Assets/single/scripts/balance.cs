using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balance : MonoBehaviour
{
    public Slider mainSlider;

    float step;
    bool IsRight;
    private void Start()
    {
        System.Random random = new System.Random();

        int sign = random.Next(0, 2);

        switch (sign)
        {
            case 0:
                IsRight = true;
                break;

            case 1:
                IsRight = false;
                break;
        }
    }

    private void FixedUpdate()
    {
        if (TimerScript.IsStarted)
        {
            float temp = Step();
            mainSlider.value += temp;
            print(temp);
        }
    }
    
    float Step()
    {
        float res;
        System.Random random = new System.Random();

        int temp = random.Next(3,11);
        int sign = random.Next(0, 101);
        Start();
        if(sign <= 50)
        {
            if(IsRight)
            {
                sign = 1;
            }
            else
            {
                sign = -1;
            }
        }

        else
        {
            if (IsRight)
            {
                sign = -1;
            }
            else
            {
                sign = 1;
            }
        }

        switch (temp)
        {
            case 3:
                res = 0.0018f;
                break;
            case 4:
                res = 0.0024f;
                break;
            case 5:
                res = 0.003f;
                break;
            case 6:
                res = 0.0036f;
                break;
            case 7:
                res = 0.0042f;
                break;
            case 8:
                res = 0.0048f;
                break;
            case 9:
                res = 0.0054f;
                break;
            case 10:
                res = 0.06f;
                break;

            default:
                res = 0.0f;
                break;
        }

        return res * sign; ;

    }
}

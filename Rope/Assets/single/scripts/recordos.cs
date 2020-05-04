using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recordos : MonoBehaviour
{
    public Text record;

    private void Start()
    {
        string rec = Convert.ToString(recordSystem.LoadRecord());
        record.text = $"{rec[0]}{rec[1]}{rec[2]}{rec[3]}{rec[4]}";
    }

    private void Update()
    {
        if (TimerScript.IsStarted)
        {
            if (TimerScript.timePassed > recordSystem.LoadRecord())
            {
                string timeStr = Convert.ToString(TimerScript.timePassed);
                try
                {
                    record.text = $"{timeStr[0]}{timeStr[1]}{timeStr[2]}{timeStr[3]}";
                }
                catch (Exception)
                {
                    try
                    {
                        record.text = $"{timeStr[0]}{timeStr[1]}{timeStr[2]}";
                    }
                    catch (Exception)
                    {
                        record.text = $"{timeStr[0]}";
                    }
                }
            }
        }
    }
}

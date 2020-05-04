using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifrec : MonoBehaviour
{
    public GameObject newrec;
    public Text res;

    void Start()
    {
        if(singleScript.IsNewRecord)
        {
            newrec.SetActive(true);
        }
        string timeStr = Convert.ToString(TimerScript.timePassed);
        res.text = $"{timeStr[0]}{timeStr[1]}{timeStr[2]}{timeStr[3]}";
    }
}

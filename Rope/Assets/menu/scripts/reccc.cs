using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reccc : MonoBehaviour
{
    public Text record;

    void Start()
    {
        string rec = Convert.ToString(recordSystem.LoadRecord());
        record.text = $"{rec[0]}{rec[1]}{rec[2]}{rec[3]}{rec[4]}";
    }

}

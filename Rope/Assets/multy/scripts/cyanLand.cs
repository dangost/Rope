﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cyanLand : MonoBehaviour
{
    public Slider mainSlider;

    private void OnMouseDown()
    {
        mainSlider.value += 0.05f;
    }
}

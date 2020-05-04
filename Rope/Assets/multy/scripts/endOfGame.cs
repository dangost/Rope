using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endOfGame : MonoBehaviour
{
    public Slider mainSlider;

    public static string winner;

    public bool isEnded = false;

    private void Update()
    {
        if (!isEnded)
        {
            if (mainSlider.value == 0.0f)
            {
                winner = "Green";
                isEnded = true;
            }

            else if (mainSlider.value == 1.0f)
            {
                winner = "Cyan";
                isEnded = true;
            }
        }
        
        else
        {
            SceneManager.LoadScene("staticMenu");
        }

    }
}

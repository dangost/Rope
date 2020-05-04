using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordSystem : MonoBehaviour
{
    private void Start()
    {
        
    }

    public static void SaveRecord(float record)
    {
        PlayerPrefs.SetFloat("Record", record);
    }

    public static float LoadRecord()
    {
        return PlayerPrefs.GetFloat("Record");
    }
}

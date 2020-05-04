using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("DoublePlayer");
    }
}

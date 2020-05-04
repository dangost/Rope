using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reestart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SingleGame");
    }
}

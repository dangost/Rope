using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mmenu : MonoBehaviour
{
    private void OnMouseDown()
    {
       
        SceneManager.LoadScene("menu");
    }
}

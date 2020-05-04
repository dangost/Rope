using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticSceneScript : MonoBehaviour
{
    public GameObject cyan, green;
    private void Start()
    {
        switch (endOfGame.winner)
        {
            case "Cyan":
                cyan.SetActive(true);
                break;

            case "Green":
                green.SetActive(true);
                break;
        }
        
    }
}

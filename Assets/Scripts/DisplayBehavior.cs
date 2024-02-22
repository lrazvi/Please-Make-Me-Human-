using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayBehavior : MonoBehaviour
{
    public GameObject InGameDisplay;
    
    void Start()
    {
        Time.timeScale = 1f;
        InGameDisplay.SetActive(true);
    }
}

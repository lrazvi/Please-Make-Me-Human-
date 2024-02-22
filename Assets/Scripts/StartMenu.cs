using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject StartScreen;
    public GameObject Introduction; 
    //public GameObject InGameDisplay;
    //public GameObject Instructions;
    
    // Start is called before the first frame update
    void Start()
    {
        //StartScreen.SetActive(false);
        StartScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    // When clicking start button
    public void Enter()
    {
        StartScreen.SetActive(false);
        //Time.timeScale = 1f;
        //Instructions.SetActive(true);
        //InGameDisplay.SetActive(true);
        Introduction.SetActive(true);
    }
}

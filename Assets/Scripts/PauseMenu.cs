using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //used tutorial from Brackeys on youtube
    
    public static bool IsPaused = false;
    public GameObject PauseScreen;

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1f;
        PauseScreen.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void Pause()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }
}

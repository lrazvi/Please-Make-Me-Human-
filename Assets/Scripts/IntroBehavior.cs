using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBehavior : MonoBehaviour
{
    public GameObject InGameDisplay;
    public GameObject Instructions;
    public GameObject Intro;
    public GameObject IntroText;

    // Start is called before the first frame update
    void Start()
    {
        Intro.SetActive(false);
    }
}

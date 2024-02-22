using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructBehavior : MonoBehaviour
{
    public GameObject TextPanel;

    // Start is called before the first frame update
    void Start()
    {
        TextPanel.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Dismiss();
        }
    }

    public void Dismiss()
    {
        TextPanel.SetActive(false);
    }
}

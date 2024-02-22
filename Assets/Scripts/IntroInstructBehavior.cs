using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroInstructBehavior : MonoBehaviour
{
    public GameObject Instruction;

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instruction.SetActive(false);
        }
    }
}

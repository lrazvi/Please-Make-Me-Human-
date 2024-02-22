using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBehavior : MonoBehaviour
{
    public GameObject Dialogue;

    // Start is called before the first frame update
    void Start()
    {
        Dialogue.SetActive(false);
    }
}

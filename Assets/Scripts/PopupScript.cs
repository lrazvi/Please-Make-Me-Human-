using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScript : MonoBehaviour
{
    public GameObject TalkPrompt;
    public GameObject GateError;

    void Start()
    {
        TalkPrompt.SetActive(false);
        GateError.SetActive(false);
    }
}

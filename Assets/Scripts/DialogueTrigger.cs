using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject TalkPrompt;
    public GameObject CharacterDialogue;
    public GameObject Frog;
    private bool inRange = false;

    void Update()
    {
        InitiateDialogue();
    }

    // player getting in dialogue range
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Frog_LOD0")
        {
            TalkPrompt.SetActive(true);
            inRange = true;
        }
    }

    // player leaving dialogue range
    void OnTriggerExit(Collider other)
    {
        //4
        if(other.name == "Frog_LOD0")
        {
            TalkPrompt.SetActive(false);
            inRange = false;
        }
    }

    void InitiateDialogue()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange == true)
        {
            CharacterDialogue.SetActive(true);
            TalkPrompt.SetActive(false);
            Frog.GetComponent<NewFrogMovement>().MoveSpeed = 0f;
            Frog.GetComponent<NewFrogMovement>().RotateSpeed = 0f;
        }
    }
}

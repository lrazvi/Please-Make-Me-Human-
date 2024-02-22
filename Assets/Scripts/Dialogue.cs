using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//used tutorial from BMo on youtube

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject Frog;

    private int index;
    private bool isComplete = false;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        //goes to next line when left click
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                //gets current line and instantly fills out
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    //starts going through index of array of dialogue lines
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //turns string into character array and types out one by one
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        //moves to next line in array of dialogue
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            //gets rid of text box when dialogue is finished
            gameObject.SetActive(false);
            isComplete = true;
            Frog.GetComponent<NewFrogMovement>().MoveSpeed = 6f;
            Frog.GetComponent<NewFrogMovement>().RotateSpeed = 65f;
            RepeatDialogue();
        }
    }

    void RepeatDialogue()
    {
        if (isComplete == true)
        {
            index = 0;
        }
    }
}

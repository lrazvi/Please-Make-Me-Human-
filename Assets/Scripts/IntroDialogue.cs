using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//used tutorial from BMo on youtube

public class IntroDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed = 0.02f;
    public GameObject Instructions;
    public GameObject InGameDisplay;
    public GameObject Intro;

    public int index;

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
            Intro.SetActive(false);
            Time.timeScale = 1f;
            Instructions.SetActive(true);
            InGameDisplay.SetActive(true);
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Rendering;

/*DIALOGUE MANAGER!
This script is a part of the Dialogue system that is being used in a Horror game that I am working on. - This was used previously in a University project, which I have now rewritten and tweaked to fit my horror game.

This script is attached to the Dialogue Controller object that is within the game and is the core of pulling and displaying the dialogue to the player. 

*/

public class DialogueManager : MonoBehaviour
{
    //Declaring the text that will display the characters name. 
    public TextMeshProUGUI[] nameText;

    //Declaring the text where the dialogue will be shown. 
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI dialogueText2;
    public Canvas dialogueCanvas; //The Canvas that will be used for this - This has been changed to the dialogue appear in the standard PlayerCanvas. 
    public string[] lines; //A string called lines that will store the dialogue. 

    private int index;
    public float textSpeed; //Float for the speed at which the text is typed out/ 
    
    public Image[] nameBox; //An image that will be the background of the character name.

    private string input;

    public Queue<string> sentences; //Declaring the queue of the sentences for the dialogue. 

    public static bool dialogueOpened;
    public Button closeDialogueButton;

    void Start()
    {
        sentences = new Queue<string>(); //Setting the queue of strings once the game scene is loaded. 

        //Ensuring that the relevant dialogue text is being displayed.
        dialogueText.gameObject.SetActive(true);
        dialogueText2.gameObject.SetActive(false);
        dialogueCanvas.gameObject.SetActive(false); //May be removing this line.
    }

    void Update()
    {
        //Nothing here... For now!
    }

    //Function that will start the dialogue and pull the names and string text from the DialogueScript. This script is called in the DialogueTrigger script to start the dialogue. 
    #region IntroDialogue
    public void StartDialogue(DialogueScript dialogue)
    {
        dialogueCanvas.gameObject.SetActive(true);
        nameText[0].text = dialogue.name;
        nameText[1].text = dialogue.name2;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayFirstSentence(); //This calls the function to trigger the first sentence of the dialogue string. 
        closeDialogueButton.gameObject.SetActive(false);

    }
    #endregion

    //Function to display the first text in the string sentence. 
    public void DisplayFirstSentence()
    {
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        nameBox[0].gameObject.SetActive(true);
        nameBox[1].gameObject.SetActive(false);
    }
    
    //Fucntion to display the next sentence in the string - This is attached to a button so it keeps getting the next sentence when the button is pressed.
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        if (dialogueText.gameObject.activeInHierarchy)
        {
            dialogueText.gameObject.SetActive(false);
            dialogueText2.gameObject.SetActive(true);
            nameBox[0].gameObject.SetActive(false);
            nameBox[1].gameObject.SetActive(true);
        }
        else if (dialogueText2.gameObject.activeInHierarchy)
        {
            dialogueText2.gameObject.SetActive(false);
            dialogueText.gameObject.SetActive(true);
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        dialogueText2.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    //Coroutine function to type out the sentences out -  This is used instead of just having the text appear. 
    IEnumerator TypeSentence(string sentence)
    {
         dialogueText.text = "";
        dialogueText2.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            dialogueText2.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        print("DONE!!!!"); //Some Debug to appear in the console for the dialogue has reached it's end. 
        closeDialogueButton.gameObject.SetActive(true); //Setting the button to active so the dialogue box can be closed. 
    }

    //Function to close the dialogue box. 
    public void CloseDialogueBox()
    {
        dialogueCanvas.gameObject.SetActive(false);
    }
}
    
 









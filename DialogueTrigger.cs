using UnityEngine;
using System;

public class DialogueTrigger : MonoBehaviour
{

/*

This script is solely for triggering the dialogue and pulling the related scripts for the dialogue.

*/
   // public TextAsset textFileAsset;
    public DialogueScript dialogue;

   //This function will be attached to a button to trigger the dialogue. - This may be changed to the player pressing a key to trigger the dialogue, or maybe kept as it is, it'll be decided later down the load once the Gameplay is finalised.
    public void TriggerDialogue()
    {
        FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);
    }

}


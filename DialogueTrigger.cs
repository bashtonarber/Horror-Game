using UnityEngine;
using System;

public class DialogueTrigger : MonoBehaviour
{
   // public TextAsset textFileAsset;
    public DialogueScript dialogue;

    public void TriggerDialogue()
    {
        FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);
    }

}

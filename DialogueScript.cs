using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

[System.Serializable]
public class DialogueScript : MonoBehaviour
{

/*

This is the script that stores the dialogue within the editor, where the dialogue text can be written in the Inspector, along with adding in the characters names.

*/

    //String to set the character names in the Inspector.
    public string name;
    public string name2;

    //Setting the string space for where the sentences can be set out in the Inspector/
    [TextArea(3, 10)]
    public string[] sentences;

    //Setting up another sentence for later in the game.
    [TextArea(3, 10)]
    public string[] sentences2;

    //Setting up another sentence for later in the game.
    [TextArea(3, 10)]
    public string[] sentences3;

    /*
    These sections that are commented out was an attempt to grab the text from text files but it ended up throwing an error and when tweaked it wouldn't actually pull the text, so this will be adjusted at a later date. 

        public TextAsset textFileAsset;

    public string filePath;
    private int currentLineIndex = 0;
    
    public void Start()
    {
        // filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/OldBookDescription.txt";
        //filePath[1] = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/OldBookDescription.txt";
        sentences[0] = textFileAsset.text;
        sentences[1] = textFileAsset.text;
        sentences[0] = GetLineAtIndex(currentLineIndex);
        currentLineIndex = 0;
    }

    private string GetLineAtIndex(int index)
    {
        string[] lines = File.ReadAllLines(filePath);
        
        if (index < lines.Length)
        {
            return lines[index];
        }
        else
        {
            return "NO MORE LINES";
        }
    }*/

}


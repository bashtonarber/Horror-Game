using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.IO;

[System.Serializable]
public class DialogueScript : MonoBehaviour
{
    public string name;
    public string name2;

    [TextArea(3, 10)]
    public string[] sentences;

    [TextArea(3, 10)]
    public string[] sentences2;

    [TextArea(3, 10)]
    public string[] sentences3;

    public TextAsset textFileAsset;

    public string filePath;
    private int currentLineIndex = 0;

    /*public void Start()
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

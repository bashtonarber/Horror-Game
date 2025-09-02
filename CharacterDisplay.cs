using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEditor.VersionControl;
using System.IO;

public class CharacterDisplay : MonoBehaviour
{

/*

This script is for displaying the characters that will be in the Horror Game which will use Scriptable Objects to store the data and pull the info from it. 

This script is to be attached to the Character Display object in Unity with the Scriptable Object required attached. 

*/

    //Declaring the Scriptable Object for us within the script. 
    public ScritableObjectScript character;

    //Declaring the UI elements that will be used from the Scriptable Object.
    public Image characterImage;
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterDescription;
    public TextMeshProUGUI page;

    void Start()
    {
        //Finding the required components for each UI element that is attached to the object, including the child objects. 
        characterImage = this.transform.Find("CharacterImage").GetComponent<Image>();
        characterName = this.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        characterDescription = this.transform.Find("DescriptionText").GetComponent<TextMeshProUGUI>();
        page = this.transform.Find("PageText").GetComponent<TextMeshProUGUI>();

        //Setting the relevant UI elements to what is on the Scriptable Object.
        characterName.text = character.characterName;
        characterDescription.text = character.description;

        characterImage.sprite = character.picture;

        page.text = character.page.ToString();

    }
}


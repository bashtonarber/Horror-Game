using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEditor.VersionControl;
using System.IO;

public class CharacterDisplay : MonoBehaviour
{
    public ScritableObjectScript character;
  
    public Image characterImage;
    public TextMeshProUGUI characterName;
    public TextMeshProUGUI characterDescription;
    public TextMeshProUGUI page;

    void Start()
    {
        characterImage = this.transform.Find("CharacterImage").GetComponent<Image>();
        characterName = this.transform.Find("NameText").GetComponent<TextMeshProUGUI>();
        characterDescription = this.transform.Find("DescriptionText").GetComponent<TextMeshProUGUI>();
        page = this.transform.Find("PageText").GetComponent<TextMeshProUGUI>();

        characterName.text = character.characterName;
        characterDescription.text = character.description;

        characterImage.sprite = character.picture;

        page.text = character.page.ToString();

    }

    void Update()
    {
      
        
        characterName.text = character.characterName;
        characterDescription.text = character.description;

        characterImage.sprite = character.picture;

        page.text = character.page.ToString();
    }
}

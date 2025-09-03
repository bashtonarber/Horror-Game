using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.iOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework.Constraints;
using UnityEditor.U2D;
using UnityEngine.EventSystems;
//using UnityEngine.UIElements;

public class InventoryMenuScript : MonoBehaviour
{

/*

This script was the first one that I wrote up for the Inventory system before moving on to one that was more flexible and not relying as much on me adding in certain bits on the GameController in the Inspector.

*/

    private GameObject inventoryMenu;
    public GameObject inventoryInspector;

    //Declaring the Images and Sprites - A Header was used here to tidy up the Inspector a bit. 
    [Header ("Images")]
    public Sprite OldKeySprite;
    public Image OldKeyImage;
    public Sprite OldBookSprite;
    public Image OldBookImage;
    public Sprite KnifeSprite;
    public Image KnifeImage;
    public Sprite MedkitSprite;
    public Image MedkitImage;
    public Sprite TorchSprite;
    public Image TorchImage;
    public Image inventoryInspectImage;



    public float inventoryList;
    public int buttonNumber;

    [SerializeField]
   // private string[] inventoryButton;
    public SpriteRenderer[] buttonsprite;

    public TextMeshProUGUI inventoryName;
    public TextMeshProUGUI inventoryDescription;
    public TextMeshProUGUI inventoryInspectName;
    public string filePath;
    private int currentLineIndex = 0;

    public TextMeshProUGUI inventoryName1;
    public TextMeshProUGUI inventoryName2;
    public TextMeshProUGUI inventoryName3;
    public TextMeshProUGUI inventoryName4;

    [SerializeField]
    public TextAsset textAssetNames;

    [SerializeField]
    private string[] names;

    [SerializeField]
    private GameObject[] objsToName;

    public static bool inventoryOpened;
    public static bool inventoryInspectorOpened;

    public Button[] inventoryButtons;

    void Start()
    {
        inventoryMenu = GameObject.Find("InventoryMenu");
        //   inventoryInspector = GameObject.Find("InvetoryInspectMenu");
        inventoryOpened = false;
        inventoryInspectorOpened = false;
        SetInventoryItems();
        SetInvetoryItemNames();

        inventoryList = 1;

        inventoryButtons[0].GetComponent<Image>();

        OldKeyImage.sprite = OldKeySprite;
        OldBookImage.sprite = OldBookSprite;
        MedkitImage.sprite = MedkitSprite;
        KnifeImage.sprite = KnifeSprite;
        TorchImage.sprite = TorchSprite;
        
    }

    void Update()
    {
      

        if (inventoryOpened)
        {
            inventoryMenu.SetActive(true);
            Time.timeScale = 0;
            if (Input.GetKey(KeyCode.Escape) || Input.GetMouseButton((int)UnityEngine.UIElements.MouseButton.RightMouse))
            {
                OpenInventory();
            }
        }
        else if (!inventoryOpened)
        {
            inventoryMenu.SetActive(false);
            Time.timeScale = 1;
        }

        if (inventoryInspectorOpened)
        {
            inventoryInspector.SetActive(true);

            if (Input.GetKey(KeyCode.Escape) || Input.GetMouseButton((int)UnityEngine.UIElements.MouseButton.RightMouse))
            {
                OpenInventoryInspector();
            }
        }
        else if (!inventoryInspectorOpened)
        {
            inventoryInspector.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenInventory();
        }

        SetInvetoryItemNames();

    }

    public void OpenInventory()
    {
        
        if (!inventoryOpened)
        {
            inventoryOpened = true;
       
        }
        else if (inventoryOpened)
        {
            inventoryOpened = false;
            inventoryInspectorOpened = false;
        }


    }

    public void OpenInventoryInspector()
    {
        if (!inventoryInspectorOpened)
        {
            inventoryInspectorOpened = true;
            if (inventoryButtons[0].gameObject.tag == "Untagged")
            {
                if (inventoryButtons[0].image == OldKeyImage)
                {
                    inventoryButtons[0].tag = "OldKeyButton";
                }
            }

            if (inventoryButtons[1].gameObject.tag == "Untagged")
            {
                if (inventoryButtons[1].image == OldBookImage)
                {
                    inventoryButtons[1].tag = "OldBookButton";
                }
            }

            if (inventoryButtons[2].gameObject.tag == "Untagged")
            {
                if (inventoryButtons[2].image == KnifeImage)
                {
                    inventoryButtons[2].tag = "KnifeButton";
                }
            }

            if (inventoryButtons[3].gameObject.tag == "Untagged")
            {
                if (inventoryButtons[3].image == MedkitImage)
                {
                    inventoryButtons[3].tag = "MedkitButton";
                }
            }

            if (inventoryButtons[4].gameObject.tag == "Untagged")
            {
                if (inventoryButtons[4].image == TorchImage)
                {
                    inventoryButtons[4].tag = "TorchButton";
                }
            }
        }
        else if (inventoryInspectorOpened)
        {
            inventoryInspectorOpened = false;
            if (inventoryButtons[0].gameObject.tag == "OldKeyButton")
            {
                inventoryButtons[0].tag = "Untaged";

                if (inventoryButtons[0].image == OldKeyImage)
                {
                    inventoryButtons[0].tag = "Untaged";
                }
            }

            if (inventoryButtons[1].gameObject.tag == "OldBookButton")
            {
                if (inventoryButtons[1].image == OldBookImage)
                {
                    inventoryButtons[1].tag = "Untagged";
                }
            }
        }

 

       
    }

    public void OnButtonClicked()
    {
        GameObject clickedButtonGameObject = EventSystem.current.currentSelectedGameObject;
        Button button = clickedButtonGameObject.GetComponent<Button>();
        //  inventoryInspectImage = button.targetGraphic as Image;
        if (clickedButtonGameObject.tag == "OldKeyButton")
        {
            inventoryInspectImage.sprite = OldKeySprite;
            filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/OldKeyDescription.txt";
            inventoryDescription.text = GetLineAtIndex(currentLineIndex + 2);
            currentLineIndex = 0;
            inventoryInspectName.text = GetLineAtIndex(currentLineIndex);
        }

        if (clickedButtonGameObject.tag == "OldBookButton")
        {
            inventoryInspectImage.sprite = OldBookSprite;
            filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/OldBookDescription.txt";
            inventoryDescription.text = GetLineAtIndex(currentLineIndex + 2);
            currentLineIndex = 0;
            inventoryInspectName.text = GetLineAtIndex(currentLineIndex);
        }

        if (clickedButtonGameObject.tag == "KnifeButton")
        {
            inventoryInspectImage.sprite = KnifeSprite;
            filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/KnifeDescription.txt";
            inventoryDescription.text = GetLineAtIndex(currentLineIndex + 2);
            currentLineIndex = 0;
            inventoryInspectName.text = GetLineAtIndex(currentLineIndex);
        }

        if (clickedButtonGameObject.tag == "MedkitButton")
        {
            inventoryInspectImage.sprite = MedkitSprite;
            filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/MedkitDescription.txt";
            inventoryDescription.text = GetLineAtIndex(currentLineIndex + 2);
            currentLineIndex = 0;
            inventoryInspectName.text = GetLineAtIndex(currentLineIndex);
        }
        
            if (clickedButtonGameObject.tag == "TorchButton")
        {
            inventoryInspectImage.sprite = TorchSprite;
             filePath = Application.dataPath + "/TextFiles/" + "InventoryTextFiles" + "/TorchDescription.txt";
            inventoryDescription.text = GetLineAtIndex(currentLineIndex + 2);
            currentLineIndex = 0;
            inventoryInspectName.text = GetLineAtIndex(currentLineIndex);
        }


        /*if (inventoryInspectImage != null)
        {
            OldKeySprite = inventoryInspectImage.sprite;
            print("Image");
        }*/
    }

    public void SetInventoryItems()
    {
        OldBookSprite = Resources.Load<Sprite>("Old Book");
        OldKeySprite = Resources.Load<Sprite>("Old Key");
        KnifeSprite = Resources.Load<Sprite>("Knife");
        MedkitSprite = Resources.Load<Sprite>("Medkit");
        TorchSprite = Resources.Load<Sprite>("Torch");
    }

    public void SetInvetoryItemNames()
    {
          if (inventoryButtons[0].image == OldKeyImage)
        {
            inventoryName.text = "Old Key";
        }
            if (inventoryButtons[1].image == OldBookImage)
        {
            inventoryName1.text = "Old Book";
        }
     //   inventoryName1.text = "OldBook"; //OldBookImage.sprite.name;
        inventoryName2.text = "Knife";  //KnifeImage.sprite.name;
        inventoryName3.text = "Med Kit";  //MedkitImage.sprite.name;
        inventoryName4.text = "Torch";  //TorchImage.sprite.name;
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
    }

    public void NextLine()
    {
        
    }

   /* void ReadTextAsset()
    {
        names = textAssetNames.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
    }

    void ApplyNameToObjects()
    {
        for (int i = 0; i < objsToName.Length; i++)
        {
            objsToName[1].name = names[i];
        }
        for (int i = 0; i < inventoryDescription.name.Length; i++)
        {
            inventoryDescription.name = names[i];
        }
    }*/
}



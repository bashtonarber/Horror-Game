using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ScrollViewItem : MonoBehaviour, IPointerClickHandler
{


    [SerializeField]
    private Image childImage;

    public void ChangeImage(Sprite Image)
    {
        childImage.sprite = Image;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("Clicked"); //Debug to show that the function is working when clicked.
    }

    //Function to change the image to the one required. - In this case, it was a OldKey placholder. 
    public void OpenMenu()
    {
        
        if (childImage.sprite.name == "OldKeyPrefab")
        {
            InventoryMenuScript.inventoryOpened = true;
        }
        print("Button"); //Debug to show in the console that it works. 
    }
}


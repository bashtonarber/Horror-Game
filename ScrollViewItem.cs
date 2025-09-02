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
        print("Clicked");
    }

    public void OpenMenu()
    {
        
        if (childImage.sprite.name == "OldKeyPrefab")
        {
            InventoryMenuScript.inventoryOpened = true;
            print("Pls");
        }
        print("Button");
    }
}

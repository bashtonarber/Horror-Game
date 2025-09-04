using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour
{

/*

This Script is for the slots in the Inventory Menu. It holds the functions for adding and removing items in the UI for the Inventory Menu.

*/
    ItemsScript item;

    public Image icon;
    public Button removeButton;

    //This is the function that adds the item and is called when the player collides with an item.
    public void AddItem(ItemsScript newItem)
    {
        item = newItem;

        icon.sprite = item.itemIcon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

   
    public void OnRemoveButton()
    {
        InventoryScript.instance.Remove(item);
    }

    //This function will be used when the use of items has been implemented.
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}

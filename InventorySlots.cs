using UnityEngine;
using UnityEngine.UI;

public class InventorySlots : MonoBehaviour
{
    ItemsScript item;

    public Image icon;
    public Button removeButton;

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

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}

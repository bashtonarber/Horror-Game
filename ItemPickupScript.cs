using UnityEngine;
using TMPro;
public class ItemPickupScript : Interactable
{
    public ItemsScript item;

    public TextMeshProUGUI itemPickedUpText;
    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void Update()
    {
        
    }

    void PickUp()
    {
        Debug.Log("Picked up " + item.name);
        InventoryScriptUI.textTriggered = true;
        itemPickedUpText.text = "Picked up " + item.name;

       bool wasPickedUp =  InventoryScript.instance.Add(item);
        //add to inventory.
        if (wasPickedUp)
        {
            Destroy(gameObject);            
        }
    }
}
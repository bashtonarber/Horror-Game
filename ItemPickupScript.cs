using UnityEngine;
using TMPro;
public class ItemPickupScript : Interactable
{

/*

This script it was is attached to the item object that includes the Scriptable Object and pulls the relevant information from it. 

*/


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

    //Function for when the item is picked up and then also adds to the inventory menu. 
    void PickUp()
    {
        Debug.Log("Picked up " + item.name); //Debug to the console to make sure that it is triggering as expected.
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

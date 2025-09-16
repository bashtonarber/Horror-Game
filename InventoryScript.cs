using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

/*

This is the second and improved script for the inventory menu. This script will list out the collected objects into menu in the order that they are pricked up in and also moving down the list when one is removed. 

*/

    #region singleton
    //Declaring the script so it can be used in other scripts. 
    public static InventoryScript instance;

    //Seeting a check when the game starts to check that this is the only instance. 
    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 6;
    public List<ItemsScript> items = new List<ItemsScript>();

    //Bool function that adds the collected object to the inventory menu - This gets called in the ItemPickUpScript within the PickUp() function. 
    public bool Add(ItemsScript item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space) //If there's no more space left, then the object will not be picked. 
            {
                Debug.Log("No more space"); //Some debug for testing to make sure that it checks when there is no more space and stops the object being picked up.
                return false;
            }
            items.Add(item);

            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
            
        }
        return true;
    }

    //Function to be set to a button so the item can be removed from the inventory menu. 
    public void Remove(ItemsScript item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}


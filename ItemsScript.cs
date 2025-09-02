using System.Xml.Serialization;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemsScript : ScriptableObject
{

/*

This is the script for the Scriptable Object for items that will be used throughout the game world. 

*/
    new public string itemName = "New Item";
    public Sprite itemIcon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        //Set up use for it - This still needs to be done and will need to figure out a way to have it use per Scriptable Object type, it may need it's own script or used in the Equipment scripts. 
        Debug.Log("Using " + name); //Just a debug that appears in the Console when the funciton is called.
    }
}


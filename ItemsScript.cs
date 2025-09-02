using System.Xml.Serialization;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class ItemsScript : ScriptableObject
{
    new public string itemName = "New Item";
    public Sprite itemIcon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        //Set up use for it.
        Debug.Log("Using " + name);
    }
}

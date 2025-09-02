using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    #region singleton
    public static InventoryScript instance;

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

    public bool Add(ItemsScript item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                Debug.Log("No more space");
                return false;
            }
            items.Add(item);

            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
            
        }
        return true;
    }

    public void Remove(ItemsScript item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
        
    }
}

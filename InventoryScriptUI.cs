using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryScriptUI : MonoBehaviour
{
    public Transform itemsParent;
    InventoryScript inventory;

    InventorySlots[] slots;

    public GameObject inventoryMenu;
    public TextMeshProUGUI itemPickedUpText;
    public float textTimer = 5f;

    [SerializeField]
    public static bool textTriggered = false;

    void Start()
    {
        inventory = InventoryScript.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlots>();

        inventoryMenu.SetActive(false);
        itemPickedUpText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryMenu.SetActive(!inventoryMenu.activeSelf);
        }

        if (textTriggered)
        {
            itemPickedUpText.gameObject.SetActive(true);
            textTimer -= Time.deltaTime;
        }
        else if (!textTriggered)
        {
            itemPickedUpText.gameObject.SetActive(false);
        }

        if (textTimer <= 0)
        {
            textTriggered = false;
            textTimer = 5f;
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}

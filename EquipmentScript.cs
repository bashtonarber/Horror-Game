using UnityEngine;
using UnityEngine.UI;

public class EquipmentScript : MonoBehaviour
{
/*

An early script that was quickly written for an equipmment bar that the player will use. 

Most of this has been for testing purposes and how it will look and feel. This still requires some changes though to be tidied up. 

*/
    public Image middleItem;
    public Image middleItemBG;
    public Image rightItem;
    public Image rightItemBG;
    public Image leftItem;
    public Image leftItemBG;

    public Sprite middleItemSprite;
    public Sprite rightItemSprite;
    public Sprite leftItemSprite;

    public int counter;


    void Start()
    {
        MiddleItemSlot();
        rightItemSlot();
        leftItemSlot();
    }

    void Update()
    {
        middleItem.sprite = middleItemSprite;
        rightItem.sprite = rightItemSprite;
        leftItem.sprite = leftItemSprite;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            leftItemBG.color = Color.yellow;
            middleItemBG.color = Color.black;
            rightItemBG.color = Color.black;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            leftItemBG.color = Color.black;
            middleItemBG.color = Color.yellow;
            rightItemBG.color = Color.black;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            leftItemBG.color = Color.black;
            middleItemBG.color = Color.black;
            rightItemBG.color = Color.yellow;
        }
    }

    void MiddleItemSlot()
    {
        middleItemSprite = Resources.Load<Sprite>("Medkit");
    }

    void rightItemSlot()
    {
        rightItemSprite = Resources.Load<Sprite>("Knife");
    }

    void leftItemSlot()
    {
        leftItemSprite = Resources.Load<Sprite>("Torch");
    }
}


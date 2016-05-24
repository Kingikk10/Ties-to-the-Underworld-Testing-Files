using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {

    public string itemName;
    public string itemDescription;
    public int itemID;
    public Texture2D itemIcon;
    public enum ItemTypes
    {
        Weapon,
        Armor,
        Potions,
        Quest
    }
    public ItemTypes itemType;

    public Texture2D ItemIcon
    {
        get { return itemIcon; }
        set { itemIcon = value; }
    }
    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }
    public string ItemDescripton
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }
    public  ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}

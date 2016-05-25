using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {

    public string itemName;
    public string itemDescription;
    public int itemID;
    public Transform itemIcon;
    public Texture2D ITEMicon;
    public enum ItemTypes
    {
        Weapon,
        Armor,
        Potions,
        Quest
    }
    public ItemTypes itemType;

    public Transform ItemIcon
    {
        get { return itemIcon; }
        set { itemIcon = value; }
    }
    public Texture2D ITEMICON
    {
        get { return ITEMicon; }
        set { ITEMicon = value; }
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

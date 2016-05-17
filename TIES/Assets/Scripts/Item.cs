using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item : MonoBehaviour{

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemPower;
    public int itemSpeed;
    public ItemType itemType;
    public enum ItemType
    {
        Weapon,
        Armor,
        Consmable,
        Quest
    }
    public Item(string name,int id, string desc, int power, int speed, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + itemName);
        itemPower = power;
        itemSpeed = speed;
        itemType = type;
    }
    public Item()
    {

    }
}

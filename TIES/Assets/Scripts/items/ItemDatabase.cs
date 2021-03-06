﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
public class ItemDatabase : MonoBehaviour {

    public List<BaseItem> items = new List<BaseItem>();

    public TextAsset itemInvetory;
    public static List<BaseItem> inventoryItems = new List<BaseItem>();

    private List<Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> inventoryDictionary;

    void Awake()
    {
        //ReadItemsFromDataBase();
        //for(int i = 0; i < inventoryItemsDictionary.Count; i++)
        //{
        //    inventoryItems.Add(new BaseItem(inventoryItemsDictionary[i]));
        //}
    }
    public void ReadItemsFromDataBase()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(itemInvetory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");

        foreach(XmlNode itemInfo in itemList)
        {
            XmlNodeList itemContent = itemInfo.ChildNodes;
            inventoryDictionary = new Dictionary<string, string>();


            foreach(XmlNode content in itemContent)
            {
                switch(content.Name)
                {
                    case "ItemName":
                        inventoryDictionary.Add("ItemName", content.InnerText);
                        break;
                    case "ItemID":
                        inventoryDictionary.Add("ItemID", content.InnerText);
                        break;
                    case "ItemType":
                        inventoryDictionary.Add("ItemType", content.InnerText);
                        break;
                }
            }
            inventoryItemsDictionary.Add(inventoryDictionary);
        }
    }
    void Start()
    {
       

    }
}
 
using UnityEngine;
using System.Collections;

public class BaseStatItem : BaseItem {

    private int damage;
    private int strength;
    private int intellect;
    private int vit;
    private int dex;

    public enum RarityType
    {
        Common,
        Magic,
        Rare,
        Legendary
    }

    private RarityType rarityType;

    public RarityType Raritytype
    {
        get { return rarityType; }
        set { rarityType = value; }

    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }
   public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }
    public int Vit
    {
        get { return vit; }
        set { vit = value; }
    }
    public int Dex
    {
        get { return dex; }
        set { dex = value; }
    }
}

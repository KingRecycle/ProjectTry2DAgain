using UnityEngine;

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Holographic
}

public enum ItemType
{
    Armour,
    Modifier
}

public enum ItemSet
{
    Basic,
    LostSands
}

public class ItemData : ScriptableObject
{
    [Header("Item")]
    public int itemID;

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public ItemType itemType;
    public Rarity itemRarity;
    public ItemSet itemSet;

    public GameObject itemPrefab;
}
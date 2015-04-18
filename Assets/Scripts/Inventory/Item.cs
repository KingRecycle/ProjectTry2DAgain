using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    public ItemData itemData;
    public int TestInt;
    /*
    public string itemID;
    public string itemName;
    public string itemDescription;

    public Sprite itemIcon;

    public ItemType itemType;
    public Rarity itemRarity;
    public ItemSet itemSet;
    */

    [HideInInspector]
    //public StatModifiers statMod;//

    [SerializeField]
    public List<StatModifier> modifiers = new List<StatModifier>();

    void Start()
    {
        //statMod = transform.GetComponent<StatModifiers>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider != null && collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<Inventory>().AddItem(this);
            Destroy(this.transform);
        }
    }
}
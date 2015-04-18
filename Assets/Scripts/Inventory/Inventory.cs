using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> Bag;
    public int MaxCarry;

    public List<Item> Equiped;

    void Start()
    {
        Bag = new List<Item>();
        Equiped = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (Bag.Count >= MaxCarry)
            return;

        Bag.Add(item);
    }
}
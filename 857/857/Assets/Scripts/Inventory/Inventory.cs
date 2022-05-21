using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();
        AddItem(new Item { itemType = Item.ItemType.Toothbrush, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Sharp_Toothbrush, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Scissors,  amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Keys, amount=1 });

        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

}

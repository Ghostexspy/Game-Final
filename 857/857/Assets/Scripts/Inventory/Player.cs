using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject Inventory;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var item = GetComponent<Item>();
        if(item)
        {
            Inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }


}

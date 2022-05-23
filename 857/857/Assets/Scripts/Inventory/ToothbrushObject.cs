using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Toothbrush Object", menuName = "Inventory System/Items/Toothbrush")]

public class ToothbrushObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Toothbrush;
    }
}

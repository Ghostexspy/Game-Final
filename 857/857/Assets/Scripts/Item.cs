using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemType itemType;
    public int amount;

    public enum ItemType
    {
        Scissors,
        Toothbrush,
        Sharp_Toothbrush
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

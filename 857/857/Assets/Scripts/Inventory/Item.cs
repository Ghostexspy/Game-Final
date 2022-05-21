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
        Sharp_Toothbrush,
        Keys
    }

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Scissors:          return ItemAssets.Instance.Scissors;
            case ItemType.Toothbrush:        return ItemAssets.Instance.Toothbrush;
            case ItemType.Keys:              return ItemAssets.Instance.Keys;
            case ItemType.Sharp_Toothbrush:  return ItemAssets.Instance.Sharp_Toothbrush;

        }
    }
}

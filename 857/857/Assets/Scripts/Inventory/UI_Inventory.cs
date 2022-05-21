using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    Transform itemSlotContainer;
    Transform itemSlotTemplate;


    private void Awake()
    {
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotContainer = itemSlotContainer.Find("itemSlotTemplate");

    }
    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }

    void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30;
        foreach (Item item in inventory.GetItemList())
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
           
            Image image= itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            
            x++;
            if (x>4)
            {
                x = 0;
                y++;
            }
        }
    }
}

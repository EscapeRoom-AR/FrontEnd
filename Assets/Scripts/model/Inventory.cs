using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    private List<InteractiveItem> itemsInventory;
    public GameObject InventoryObject;
    public List<Image> itemsImages;

    public void Start()
    {
        itemsInventory = new List<InteractiveItem>();
        itemsImages = new List<Image>();
        for (int i = 1; i <= 5; i++)
        {
            itemsImages.Add(InventoryObject.transform
                .Find("inventorySlot" + i)
                .Find("border")
                .Find("itemImage")
                .GetComponent<Image>()
            );
        }
        
    }

    internal void removeItemsWithTag(string tag)
    {
        foreach (InteractiveItem item in itemsInventory)
        {
            if (item.tag.Equals(tag)) {
                itemsInventory.Remove(item);
            }
        }
        UpdateUI();
    }

    public void addToInventory(InteractiveItem item) {
        itemsInventory.Add(item);
        UpdateUI();
    }

    public void removeFromInventory(InteractiveItem item) {
        itemsInventory.Remove(item);
        UpdateUI();
    }

    private void UpdateUI()
    {
        int i = 0;
        foreach (Image item  in itemsImages)
        {
            if (i < itemsInventory.Count)
                item.sprite = itemsInventory[i].Sprite;
            else
                item.sprite = null;
            i++;
        }
    }

}

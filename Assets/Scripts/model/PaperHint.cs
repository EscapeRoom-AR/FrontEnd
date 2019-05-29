using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ItemInstance
{
    // Reference to scriptable object "template".
    public Item item;
    // Object-specific data.

    public ItemInstance(Item item)
    {
        this.item = item;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperMouseDown : MonoBehaviour
{
    public PaperHintController controller;
    
    private void OnMouseDown()
    {
        Debug.Log(gameObject.tag);
        InteractiveItem item = new InteractiveItem(gameObject.GetComponent<Image>().sprite, tag);
       // inventory.addToInventory(item);
        Destroy(gameObject);
    }
}

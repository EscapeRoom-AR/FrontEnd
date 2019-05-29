using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperHintController : MonoBehaviour
{
    public GameObject modalPrefab;
    public Canvas canvas;
    public Inventory inventory;
    public int papersPicked = 0;
    private static string tag = "paper";

    private void OnMouseDown()
    {
        papersPicked++;
        if (papersPicked == 4) Complete();
        Debug.Log(gameObject.tag);
        InteractiveItem item = new InteractiveItem(gameObject.GetComponent<Image>().sprite, tag);
        inventory.addToInventory(item);
        Destroy(gameObject);
    }

    private void Complete()
    {
        inventory.removeItemsWithTag(tag);
        GameObject modal = Instantiate(modalPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        modal.transform.SetParent(canvas.transform, false);
        modal.transform.Find("Button").GetComponent<Button>().onClick.AddListener(() => Destroy(modal));
    }   
}


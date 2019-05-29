using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveItem 
{
    public Sprite Sprite;
    public string tag;

    public InteractiveItem(Sprite sprite, string tag)
    {
        Sprite = sprite;
        tag = tag;
    }
}

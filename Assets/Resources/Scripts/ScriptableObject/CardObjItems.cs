using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { Upgrade,Curse }
[CreateAssetMenu(fileName = "Object", menuName = "Card/Item")]
public class CardObjItems : ScriptableObject
{
    [Header("Type")]
    public ItemType Type;
    [Header("Text")]
    public string Name;

    [Header("Image")]
    public Sprite Image;
    public Sprite Icon;

    [Header("Colors")]
    public Color FrameColor;
    public Color BgColor;
    public Color TextTypeColor;

    [Header("Behaviour")]
    public CardsBehaviour Behaviour;
}

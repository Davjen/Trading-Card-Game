using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardInitializatorItems : MonoBehaviour
{
    public CardObjItems Card;
    
    [Header("Texts")]
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Description;
    public TextMeshProUGUI Type;
    
    [Header("Images")]
    public Image IconType;
    public Image Image;
    public Image Frame;
    public Image Background;



    // Start is called before the first frame update
    void Start()
    {
        Name.text = Card.Name;
        //Description.text = Card.Behaviour.Description;
        Type.text = Card.Type == ItemType.Upgrade ? "Oggetto" : "Oggetto Maledetto";
        Type.color = Card.TextTypeColor;

        IconType.sprite = Card.Icon;
        Image.sprite = Card.Image;
        Frame.color = Card.FrameColor;
        Background.color = Card.BgColor;
    }
}

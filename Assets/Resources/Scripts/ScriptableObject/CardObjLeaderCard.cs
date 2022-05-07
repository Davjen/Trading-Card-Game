using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HeroType { Bard, Warrior, Mage, Rogue, Assassin, Ranger, Guardian };
[CreateAssetMenu(fileName = "Leader", menuName = "Card/Leader")]
public class LeaderCardSO : ScriptableObject
{
    [Header("Text")]
    public string Name;
    [TextArea]
    public string Description;
    [Header("Images")]
    [Space(20)]
    public Sprite Icon;
    public Sprite Image;
    [Space(20)]
    public HeroType Type;
    public LeadersSpecialEffect SpecialEffect;


}

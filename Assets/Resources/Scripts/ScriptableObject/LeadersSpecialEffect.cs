using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Context { Attack,Challange,PlayMagic,HeroEffect,Modifier,OncePerTurn}
[CreateAssetMenu(fileName = "LeaderBonus", menuName = "Bonus/LeaderBonus")]
public class LeadersSpecialEffect : ScriptableObject
{
    public Context Context;
    public int DiceValueAdded;
    public int ExtraCardsToPick;
    public string Target; //TO MODIFY INTO CHARACTER
    [TextArea]
    public string BonusDescription;
}

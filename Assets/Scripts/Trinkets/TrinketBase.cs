using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Trinket", menuName = "Darkest Dungeon/Create new Trinket", order = 0)]

public class TrinketBase : ScriptableObject
{
    [SerializeField] string _name;
    [SerializeField] [Range(0, 4)] int rarity;
    [SerializeField] HeroJob classRestriction;
    [SerializeField] Dungeon dropLocation;
    [SerializeField] List<StatsBoost> effects;
}


public enum Dungeon { Ruins, Warrens, Weald, Cove, DarkestDungeon }

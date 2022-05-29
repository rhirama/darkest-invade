using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill Set", menuName = "Darkest Dungeon/Create new Skill Set")]


public class SkillSetBase : ScriptableObject
{
    [SerializeField] private List<SkillBase> skillSet;

    public List<SkillBase> SkillSet {
        get {return skillSet;}
    }
}

public enum Range { Melee, Ranged }

public enum Target { Self, Enemy, Ally }

[System.Serializable]
public class SkillBase {

    [SerializeField] private string skillName;
    [SerializeField] private Sprite icon;
    [SerializeField] private Range range;
    [SerializeField] private List<int> rank;
    [SerializeField] private Target target;
    [SerializeField] private List<int> targetRank;
    [SerializeField] private int damage;
    [SerializeField] private int accuracy;
    [SerializeField] private int critMod;

    public string SkillName {
        get {return skillName;}
    }

    public Sprite Icon {
        get {return icon;}
    }
    
    public Range Range {
        get {return range;}
    }

    public List<int> Rank{
        get{return rank;}
    }

    public Target Target {
        get {return target;}
    }

    public List<int> TargetRank {
        get {return targetRank;}
    }

    public int Damage {
        get {return damage;}
    }

    public int Accuracy {
        get {return accuracy;}
    }

    public int CritMod {
        get {return critMod;}
    }
}


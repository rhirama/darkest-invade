using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Range { Melee, Ranged }
public enum Target { Self, Enemy, Ally }

[CreateAssetMenu(fileName = "Skill Set", menuName = "Darkest Dungeon/Create new Skill")]

public class SkillBaseSO : ScriptableObject
{
    [SerializeField] private string skillName;
    [SerializeField] private Sprite icon;
    [SerializeField] private Range range;
    [SerializeField] private List<int> rank;
    [SerializeField] private Target target;
    [SerializeField] private List<int> targetRank;
    [SerializeField] private int damageMod;
    [SerializeField] private float accuracy;
    [SerializeField] private float critMod;
    [SerializeField] private int minDamage;
    [SerializeField] private int maxDamage;

    public string SkillName
    {
        get { return skillName; }
    }

    public Sprite Icon
    {
        get { return icon; }
    }

    public Range Range
    {
        get { return range; }
    }

    public List<int> Rank
    {
        get { return rank; }
    }

    public Target Target
    {
        get { return target; }
    }

    public List<int> TargetRank
    {
        get { return targetRank; }
    }

    public int DamageMod
    {
        get => damageMod;
    }
    public float Accuracy { get => accuracy; set => accuracy = value; }
    public float CritMod { get => critMod; set => critMod = value; }

    public int MinDamage
    {
        get => minDamage;
    }

    public int MaxDamage
    {
        get => maxDamage;
    }

    public SkillBaseSO SetSkillLevel(SkillBaseSO skillBase, int level)
    {
        var skill = new SkillBaseSO();

        skill.Accuracy = skillBase.Accuracy + (level - 1) * 5;
        skill.CritMod = skillBase.CritMod + (level - 1) * 1;

        return skill;
    }
}

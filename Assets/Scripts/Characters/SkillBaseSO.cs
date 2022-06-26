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


    #region Properties
    public string SkillName { get => skillName; }

    public Sprite Icon { get => icon; }

    public Range Range { get => range; }

    public List<int> Rank { get => rank; }

    public Target Target { get => target; }

    public List<int> TargetRank { get => targetRank; }

    public int DamageMod { get => damageMod; }

    public float Accuracy { get => accuracy; set => accuracy = value; }

    public float CritMod { get => critMod; set => critMod = value; }

    public int MinDamage { get => minDamage; }

    public int MaxDamage { get => maxDamage; }
    #endregion

    public static SkillBaseSO SetSkillLevel(SkillBaseSO skillBase, int level)
    {
        var skill = new SkillBaseSO();

        skill.Accuracy = skillBase.Accuracy + (level - 1) * 5;
        skill.CritMod = skillBase.CritMod + (level - 1) * 1;

        return skill;
    }
}

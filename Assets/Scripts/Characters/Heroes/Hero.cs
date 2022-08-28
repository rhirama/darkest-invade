using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero
{
    [SerializeField] private string heroName;
    private HeroBaseSO heroBase;
    [SerializeField] [Range(1, 5)] private int resolveLevel;
    [SerializeField] [Range(1, 5)] private int weaponLevel;
    [SerializeField] [Range(1, 5)] private int armorLevel;

    private List<SkillBaseSO> skillSet;
    private List<int> skillLevel;

    private int hp;
    private int stress;

    private Stats stats;
    private Resistances resistances;

    private Weapon _weapon;

    #region Properties
    public HeroBaseSO Base { get => heroBase; }

    public string Name { get => heroName; set => heroName = value; }

    public int ResolveLevel { get => resolveLevel; }
    
    public int WeaponLevel { get => weaponLevel; }

    public Weapon Weapon  { get => _weapon; }
    
    public int ArmorLevel { get => armorLevel; }
    
    public Stats Stats { get => stats; }
    
    public Resistances Resistances { get => resistances; }
    
    public List<int> SkillLevel { get => skillLevel; }

    public List<SkillBaseSO> SkillSet { get => skillSet; }

    public int Hp { get => hp; set => hp = value; }

    public int Stress { get => stress; set => stress = value; }
    #endregion

    public Hero(HeroBaseSO hBase, int resolveLevel, int weaponLevel, int armorLevel, string heroName)
    {
        var weapon = new Weapon(hBase.Weapons, weaponLevel);
        var armor = new Armor(hBase.Armors, armorLevel);
        var skillSet = new List<SkillBaseSO>();


        foreach (SkillBaseSO skillBase in hBase.SkillSet)
        {
            var skill = skillBase;
            skill.SetSkillLevel(skillBase, resolveLevel);

            skillSet.Add(skill);
        }

        this.skillSet = skillSet;
        this._weapon = weapon;
        this.weaponLevel = weaponLevel;
        this.armorLevel = armorLevel;
        this.heroBase = hBase;
        this.stats = new Stats(hBase, weapon, armor);
        this.Name = heroName;
        this.hp = stats.MaxHP;
        this.stress = 0;
    }

}

public class Armor 
{

    public string Name { get; set; }
    public int Level { get; set; }
    public int MaxHP { get; set; }
    public float Dodge { get; set; }

    public Armor(ArmorSetBaseSO setBase, int armorLevel){

        Name = setBase.ArmorSet[armorLevel - 1].ArmorName;
        Level = armorLevel;
        MaxHP = setBase.ArmorSet[armorLevel - 1].MaxHP;
        Dodge = setBase.ArmorSet[armorLevel - 1].Dodge;
    }
}

public class Weapon : IHaveTooltip
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public float Crit { get; set; }
    public int Speed { get; set; }

    public Weapon(WeaponSetBaseSO setBase, int weaponLevel)
    {
        Name = setBase.WeaponSet[weaponLevel - 1].WeaponName;
        Level = weaponLevel;
        MinDamage = setBase.WeaponSet[weaponLevel - 1].MinDamage;
        MaxDamage = setBase.WeaponSet[weaponLevel - 1].MaxDamage;
        Crit = setBase.WeaponSet[weaponLevel - 1].Crit;
        Speed = setBase.WeaponSet[weaponLevel - 1].Speed;

    }

    public string BuildTooltipText()
    {
        string text = $"{this.Name}" +
            $"\nDMG base: {this.MinDamage} - {this.MaxDamage}" +
            $"\nCRIT base: {this.Crit} %" +
            $"\nSPD base: {this.Speed}";

        return text;
    }
}

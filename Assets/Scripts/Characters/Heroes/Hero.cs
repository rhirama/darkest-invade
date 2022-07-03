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

    #region Properties
    public HeroBaseSO Base { get => heroBase; }

    public string Name { get => heroName; set => heroName = value; }

    public int ResolveLevel { get => resolveLevel; }
    
    public int WeaponLevel { get => weaponLevel; }
    
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
        this.weaponLevel = weaponLevel;
        this.armorLevel = armorLevel;
        this.heroBase = hBase;
        this.stats = new Stats(hBase, weapon, armor);
        this.Name = heroName;
        this.hp = stats.MaxHP;
        this.stress = 0;
    }

}

public class Armor {
    public int Level { get; set; }
    public int MaxHP { get; set; }
    public float Dodge { get; set; }

    public Armor(ArmorSetBaseSO setBase, int armorLevel){
        
        Level = armorLevel;
        MaxHP = setBase.ArmorSet[armorLevel - 1].MaxHP;
        Dodge = setBase.ArmorSet[armorLevel - 1].Dodge;
    }
}

public class Weapon
{
    public int Level { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public float Crit { get; set; }
    public int Speed { get; set; }

    public Weapon(WeaponSetBaseSO setBase, int weaponLevel)
    {
        Level = weaponLevel;
        MinDamage = setBase.WeaponSet[weaponLevel - 1].MinDamage;
        MaxDamage = setBase.WeaponSet[weaponLevel - 1].MaxDamage;
        Crit = setBase.WeaponSet[weaponLevel - 1].Crit;
        Speed = setBase.WeaponSet[weaponLevel - 1].Speed;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Hero
{
    [SerializeField] private HeroBase _base;
    [SerializeField] [Range(1, 5)] private int _resolveLevel;
    [SerializeField] [Range(1, 5)] private int _weaponLevel;
    [SerializeField] [Range(1, 5)] private int _armorLevel;

    [SerializeField] private List<SkillBaseSO> _skillSet;
    [SerializeField] private List<int> _skillLevel;

    private Stats _stats;
    private Resistances _resistances;

    public HeroBase Base
    {
        get { return _base; }
    }
    public int ResolveLevel
    {
        get { return _resolveLevel; }
    }
    public int WeaponLevel
    {
        get { return _weaponLevel; }
    }
    public int ArmorLevel
    {
        get { return _armorLevel; }
    }
    public Stats Stats
    {
        get { return _stats; }
    }
    public Resistances Resistances
    {
        get { return _resistances; }
    }
    public List<int> SkillLevel { get => _skillLevel; }
    public List<SkillBaseSO> SkillSet { get => _skillSet; }

    public Hero(HeroBase heroBase, int resolveLevel, int weaponLevel, int armorLevel)
    {
        var weapon = new Weapon(heroBase.Weapons, weaponLevel);
        var armor = new Armor(heroBase.Armors, armorLevel);

        var skillSet = new List<SkillBaseSO>();

        foreach (SkillBaseSO skillBase in heroBase.SkillSet)
        {
            var skill = new SkillBaseSO();

            skill = skill.SetSkillLevel(skillBase, resolveLevel);

            skillSet.Add(skill);
        }

        _skillSet = skillSet;

        _weaponLevel = weaponLevel;
        _armorLevel = armorLevel;
        _base = heroBase;
        _stats = new Stats(heroBase, weapon, armor);

    }

}

public class Armor {
    public int Level { get; set; }
    public int MaxHP { get; set; }
    public float Dodge { get; set; }

    public Armor(ArmorSetBase setBase, int armorLevel){
        
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

    public Weapon(WeaponSetBase setBase, int weaponLevel)
    {
        Level = weaponLevel;
        MinDamage = setBase.WeaponSet[weaponLevel - 1].MinDamage;
        MaxDamage = setBase.WeaponSet[weaponLevel - 1].MaxDamage;
        Crit = setBase.WeaponSet[weaponLevel - 1].Crit;
        Speed = setBase.WeaponSet[weaponLevel - 1].Speed;

    }

}

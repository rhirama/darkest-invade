using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int Prot { get; set; }
    public float AccMod { get; set; }

    // Armor
    public int MaxHP { get; set; }
    public float Dodge { get; set; }

    // Weapon
    public float Crit { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int Speed { get; set; }

    // Construtor dos status do heroi
    public Stats(HeroBaseSO hero, Weapon weapon, Armor armor)
    {
        Prot = hero.BaseStats.Prot;
        AccMod = hero.BaseStats.AccuracyMod;
        Crit = weapon.Crit;
        MinDamage = weapon.MinDamage;
        MaxDamage = weapon.MaxDamage;
        Speed = weapon.Speed;
        MaxHP = armor.MaxHP;
        Dodge = armor.Dodge;
    }
    
    // Construtor dos satatus do inimigo
    public Stats(EnemyBaseSO enemy, int level)
    {
        MaxHP = enemy.BaseStats[level].MaxHP;
        Prot = enemy.BaseStats[level].Prot;
        AccMod = enemy.BaseStats[level].AccuracyMod;
        Dodge = enemy.BaseStats[level].Dodge;
        Crit = 0;
        Speed = enemy.BaseStats[level].Speed;
    }
}

public class StatsBoost
{
    public Stats Stats { get; set; }
    public int boost { get; set; }
}

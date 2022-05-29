using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int Prot { get; set; }
    public int AccMod { get; set; }

    ////Armor

    //public int MaxHP { get; set; }
    //public int Dodge { get; set; }

    //Weapon

    public int Crit { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int Speed { get; set; }

    public Stats(HeroBase hero, Weapon weapon)
    {
        Prot = hero.BaseStats.Prot;
        AccMod = hero.BaseStats.AccuracyMod;
        Crit = weapon.Crit;
        MinDamage = weapon.MinDamage;
        MaxDamage = weapon.MaxDamage;
        Speed = weapon.Speed;
    }
}

public class StatsBoost
{
    public Stats Stats { get; set; }
    public int boost { get; set; }
}

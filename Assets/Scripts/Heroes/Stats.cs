using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    //public int Prot { get; set; }
    //public int AccMod { get; set; }

    ////Resistance
    //public int Stun { get; set; }
    //public int Blight { get; set; }
    //public int Disease { get; set; }
    //public int Move { get; set; }
    //public int Bleed { get; set; }
    //public int Debuff { get; set; }

    ////Armor

    //public int MaxHP { get; set; }
    //public int Dodge { get; set; }

    //Weapon

    public int Crit { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int Speed { get; set; }

    public Stats(Weapon weapon)
    {
        Crit = weapon.Crit;
        MinDamage = weapon.MinDamage;
        MaxDamage = weapon.MaxDamage;
        Speed = weapon.Speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Darkest Dungeon/Create new Weapon")]

public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName;

    [SerializeField] private int crit;

    [SerializeField] private int minDamage;

    [SerializeField] private int maxDamage;

    [SerializeField] private int speed;

    public string WeaponName {
        get { return weaponName; }
    }

    public int Crit {
        get { return crit; }
    }

    public int MinDamage {
        get { return minDamage; }
    }

    public int MaxDamage {
        get { return maxDamage; }
    }

    public int Speed {
        get { return speed; }
    }

}

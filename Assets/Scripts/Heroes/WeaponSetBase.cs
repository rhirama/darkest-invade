using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon Set", menuName = "Darkest Dungeon/Create new Weapon", order = 0)]

public class WeaponSetBase : ScriptableObject
{
    [SerializeField] private List<WeaponBase> weaponSet;

    public List<WeaponBase> WeaponSet
    {
        get { return weaponSet; }
    }
}

[System.Serializable]
public class WeaponBase
{
    [SerializeField] private string weaponName;
    [SerializeField] private Sprite icon;
    [SerializeField] private int minDamage;
    [SerializeField] private int maxDamage;
    [SerializeField] private int crit;
    [SerializeField] private int speed;

    public string WeaponName
    {
        get { return weaponName; }
    }

    public Sprite Icon
    {
        get { return icon; }
    }

    public int MinDamage
    {
        get { return minDamage; }
    }

    public int MaxDamage
    {
        get { return maxDamage; }
    }
    public int Crit
    {
        get { return crit; }
    }

    public int Speed
    {
        get { return speed; }
    }


}

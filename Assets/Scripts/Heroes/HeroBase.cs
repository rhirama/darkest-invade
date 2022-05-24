using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero base", menuName = "Darkest Dungeon/Create new Hero", order = 0)]

public class HeroBase : ScriptableObject
{
    [SerializeField] private List<HeroBaseStats> heroBaseStats;
    [SerializeField] private Sprite baseSprite;
    [SerializeField] private Sprite icon;
    [SerializeField] private WeaponSetBase weapons;
    [SerializeField] private string job;

    [SerializeField] private Resistances _resistances;


    public string Job
    {
        get { return job; }
    }
    public Sprite BaseSprite
    {
        get { return baseSprite; }
    }
    public Sprite Icon
    {
        get { return icon; }
    }
    public List<HeroBaseStats> BaseStats
    {
        get { return heroBaseStats; }
    }
    public WeaponSetBase Weapons
    {
        get { return weapons; }
    }
    public Resistances Resistances 
    {
        get { return _resistances; } 
    }

}


[System.Serializable]
public class HeroBaseStats
{
    [SerializeField] private int prot;
    [SerializeField] private int accuracyMod;
    [SerializeField] private bool religious;

    public int Prot
    {
        get { return prot; }
    }

    public int AccuracyMod
    {
        get { return accuracyMod; }
    }

    public bool Religious
    {
        get { return religious; }
    }
}

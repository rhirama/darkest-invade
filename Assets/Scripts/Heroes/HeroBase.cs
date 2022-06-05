using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero base", menuName = "Darkest Dungeon/Create new Hero", order = 0)]

public class HeroBase : ScriptableObject
{
    [SerializeField] private HeroJob job;
    [SerializeField] private string _name;
    [SerializeField] private HeroBaseStats baseStats;
    [SerializeField] private Sprite baseSprite;
    [SerializeField] private Sprite icon;
    [SerializeField] private WeaponSetBase weapons;
    [SerializeField] private ArmorSetBase armors;

    [SerializeField] private Resistances _resistances;


    public HeroJob Job
    {
        get { return job; }
    }

    public string Name
    {
        get { return _name; }
    }

    public Sprite BaseSprite
    {
        get { return baseSprite; }
    }

    public Sprite Icon
    {
        get { return icon; }
    }

    public HeroBaseStats BaseStats
    {
        get { return baseStats; }
    }

    public WeaponSetBase Weapons
    {
        get { return weapons; }
    }

    public Resistances Resistances 
    {
        get { return _resistances; } 
    }

    public ArmorSetBase Armors 
    {
        get {return armors;}
    }
    

}


[System.Serializable]
public class HeroBaseStats
{
    [SerializeField] private int prot;
    [SerializeField] private float accuracyMod;
    [SerializeField] private bool religious;
    [SerializeField] private int moveForwards;
    [SerializeField] private int moveBackwards;

    public int Prot
    {
        get { return prot; }
    }

    public float AccuracyMod
    {
        get { return accuracyMod; }
    }

    public bool Religious
    {
        get { return religious; }
    }

    public int MoveForwards
    {
        get { return moveForwards; }
    }

    public int MoveBackwards
    {
        get { return moveBackwards; }
    }
}

public enum HeroJob { Crusader, Hellion, Leper, Vestal, PlagueDoctor}

//public enum HeroJob { Abomination, Antiquarian, Arbalest, BontyHunter, Crusader, GraveRobber, Hellion, Highwayman, Houndmaster, Jester, Leper, ManAtArms, Musketeer, Ocultist, PlagueDoctor, Vestal }
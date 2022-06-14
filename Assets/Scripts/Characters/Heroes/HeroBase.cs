using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero base", menuName = "Darkest Dungeon/Create new Hero", order = 0)]

public class HeroBase : ScriptableObject
{
    [SerializeField] private HeroJob job;
    [SerializeField] private HeroBaseStats baseStats;
    [SerializeField] private Sprite baseSprite;
    [SerializeField] private Sprite icon;
    [SerializeField] private WeaponSetBase weapons;
    [SerializeField] private ArmorSetBase armors;
    [SerializeField] private List<SkillBaseSO> skillSet;

    [SerializeField] private Resistances _resistances;

    #region Properties
    public HeroJob Job { get => job; }

    public Sprite BaseSprite { get => baseSprite; }

    public Sprite Icon { get => icon; }

    public HeroBaseStats BaseStats { get => baseStats; }

    public WeaponSetBase Weapons { get => weapons; }

    public Resistances Resistances { get => _resistances; }

    public ArmorSetBase Armors { get => armors; }

    public List<SkillBaseSO> SkillSet { get => skillSet; }
    #endregion
}


[System.Serializable]
public class HeroBaseStats
{
    [SerializeField] private int prot;
    [SerializeField] private float accuracyMod;
    [SerializeField] private bool religious;
    [SerializeField] private int moveForwards;
    [SerializeField] private int moveBackwards;

    #region Properties
    public int Prot { get => prot; }

    public float AccuracyMod { get => accuracyMod; }

    public bool Religious { get => religious; }

    public int MoveForwards { get => moveForwards; }

    public int MoveBackwards { get => moveBackwards; }
    #endregion
}

public enum HeroJob { Crusader, Hellion, Leper, Vestal, PlagueDoctor}

//public enum HeroJob { Abomination, Antiquarian, Arbalest, BontyHunter, Crusader, GraveRobber, Hellion, Highwayman, Houndmaster, Jester, Leper, ManAtArms, Musketeer, Ocultist, PlagueDoctor, Vestal }
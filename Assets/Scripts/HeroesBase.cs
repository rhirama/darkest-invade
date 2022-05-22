using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero", menuName = "Darkest Dungeon/Create new Hero")]

public class HeroesBase : ScriptableObject
{
    [SerializeField] private string job;

    [SerializeField] private int trap;

    [SerializeField] private int deathBlow;

    [SerializeField] private int movement;

    [SerializeField] private int critBonus;

    [SerializeField] private bool religious;

    // [SerializeField] private List<CombatSkill> combatSkillList;

    // [SerializeField] private List<CampingSkill> campingSkillList;
    
    // [SerializeField] private List<Armor> armorLevel;

    // [SerializeField] private List<Weapon> weaponLevel;

    // [SerializeField] private int resolve;

    // [SerializeField] private int prot;

    // [SerializeField] private bool stealth;

    // [SerializeField] private int accMod;

    private Stats stats;

    public string Job {
        get { return job; }
    }

    public int Trap {
        get { return trap; }
    }

    public int DeathBlow {
        get { return deathBlow; }
    }

    public int Movement {
        get { return movement; }
    }

    public int CritBonus {
        get { return critBonus; }
    }

    public bool Religious {
        get { return religious; }
    }

    // public List<CombatSkill> CombatSkillList {
    //     get { return combatSkillList; }
    // }
    
    // public List<CampingSkill> CampingSkillList {
    //     get { return campingSkillList; }
    // }

    // public List<Armor> ArmorLevel {
    //     get { return armorLevel; }
    // }

    // public List<Weapon> WeaponLevel {
    //     get { return weaponLevel; }
    // }

    

}



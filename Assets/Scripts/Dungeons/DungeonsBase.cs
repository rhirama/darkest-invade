using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dungeon Base", menuName = "Darkest Dungeon/Create new Dungeon Base", order = 1)]

public class DungeonsBase : ScriptableObject
{
    [SerializeField] private string _biome;
    [SerializeField] private Difficulty difficulty;
    [SerializeField] private Size size;
    [SerializeField] private Objective objective;
    [SerializeField] private double trinketOdds;
    [SerializeField] private double encounterOdds;

    public string Biome {
        get{return _biome;}
    }

    public Difficulty Difficulty {
        get{return difficulty;}
    }

    public Size Size {
        get{return size;}
    }

    public Objective Objective {
        get{return objective;}
    }

    public double TrinketOdds {
        get{return trinketOdds;}
    }

    public double EncounterOdds {
        get{return encounterOdds;}
    }
}

public enum Difficulty {
    Apprentice,
    Veteran,
    Champion,
    Darkest
}

public enum Size {
    Short,
    Medium,
    Long
}

public enum Objective {
    Cleanse,
    Explore,
    Gather,
    Activate,
    Boss,
    Darkest
}

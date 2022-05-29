using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Resistances
{
    [SerializeField] private int stun;
    [SerializeField] private int blight;
    [SerializeField] private int disease;
    [SerializeField] private int move;
    [SerializeField] private int bleed;
    [SerializeField] private int debuff;
    [SerializeField] private int deathBlow;
    [SerializeField] private int trap;

    ////Resistance
    public int Stun { get; set; }
    public int Blight { get; set; }
    public int Disease { get; set; }
    public int Move { get; set; }
    public int Bleed { get; set; }
    public int Debuff { get; set; }
    public int DeathBlow { get; set; }
    public int Trap { get; set; }

    public Resistances setResistances(Resistances baseResistances, int resolveLevel)
    {
        var newResistances = new Resistances();
        newResistances.Stun = baseResistances.Stun + (resolveLevel * 10);
        newResistances.Blight = baseResistances.Blight + (resolveLevel * 10);
        newResistances.Disease = baseResistances.Disease + (resolveLevel * 10);
        newResistances.Move = baseResistances.Move + (resolveLevel * 10);
        newResistances.Debuff = baseResistances.Debuff + (resolveLevel * 10);
        newResistances.DeathBlow = baseResistances.DeathBlow + (resolveLevel * 10);
        newResistances.Trap = baseResistances.Trap + (resolveLevel * 10);

        return newResistances;
    }

}

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


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor Set", menuName = "Darkest Dungeon/Create new Armor")]

public class ArmorSetBase : ScriptableObject
{
    [SerializeField] private List<ArmorBase> armorSet;

    public List<ArmorBase> ArmorSet {
        get {return armorSet;}
    }
}

[System.Serializable]
public class ArmorBase {

    [SerializeField] private string armorName;
    [SerializeField] private Sprite icon;
    [SerializeField] private int maxHP;
    [SerializeField] private int dodge;

    public string ArmorName {
        get {return armorName;}
    }

    public Sprite Icon {
        get {return icon;}
    }

    public int MaxHP {
        get {return maxHP;}
    }

    public int Dodge {
        get {return dodge;}
    }
}
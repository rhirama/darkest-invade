using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Armor Set", menuName = "Darkest Dungeon/Create new Armor")]

public class ArmorSetBase : ScriptableObject
{
    [SerializeField] private List<ArmorBase> armorSet;

    public List<ArmorBase> ArmorSet { get => armorSet;}
}

[System.Serializable]
public class ArmorBase {

    [SerializeField] private string armorName;
    [SerializeField] private Sprite icon;
    [SerializeField] private int maxHP;
    [SerializeField] private float dodge;

    public string ArmorName { get => armorName; }

    public Sprite Icon { get => icon; }

    public int MaxHP { get => maxHP; }

    public float Dodge { get => dodge;}
}
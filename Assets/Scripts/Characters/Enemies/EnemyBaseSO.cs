using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy base", menuName = "Darkest Dungeon/Create new Enemy", order = 0)]

public class EnemyBaseSO : ScriptableObject
{
    [SerializeField] private string enemyName;
    [SerializeField] private List<EnemyBaseStats> baseStats;
    [SerializeField] private Sprite baseSprite;
    [SerializeField] private List<Resistances> _resistances;
    [SerializeField] private EnemyType enemyType;
    [SerializeField] private int size;
    [SerializeField] private int actionsPerRound;
    [SerializeField] private List<EnemySkillDatabase> skillSet;

    #region Properties
    public string EnemyName { get => enemyName; }

    public List<EnemyBaseStats> BaseStats { get => baseStats; }

    public Sprite BaseSprite { get => baseSprite; }

    public List<Resistances> Resistances { get => _resistances; }

    public EnemyType EnemyType { get => enemyType; }

    public int Size { get => size; }

    public int ActionsPerRound { get => actionsPerRound; }

    public List<EnemySkillDatabase> SkillSet { get => skillSet; }
    #endregion
}

[System.Serializable]
public class EnemyBaseStats
{
    [SerializeField] private int maxHP;
    [SerializeField] private int prot;
    [SerializeField] private float accuracyMod;
    [SerializeField] private float dodge;
    [SerializeField] private int speed;

    #region Properties
    public int MaxHP { get => maxHP; }

    public int Prot { get => prot; }

    public float AccuracyMod { get => accuracyMod; }

    public float Dodge { get => dodge; }

    public int Speed { get => speed; }
    #endregion
}

public enum EnemyType { Human, Eldritch, Beast, Unholy, Stonework }

[System.Serializable]
public class EnemySkillDatabase
{
    [SerializeField] private List<SkillBaseSO> skillDatabase;

    public List<SkillBaseSO> SkillDatabase { get => skillDatabase; }
}
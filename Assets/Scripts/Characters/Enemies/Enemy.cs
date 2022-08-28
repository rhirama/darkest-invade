using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Enemy
{
    [SerializeField] private EnemyBaseSO _base;
    [SerializeField][Range(0, 2)] private int _level;
    [SerializeField] private List<SkillBaseSO> _skillSet;

    private int hp;
    private Stats _stats;
    private Resistances _resistances;

    #region Properties
    public EnemyBaseSO Base { get => _base; }

    public int Level { get => _level; }

    public Stats Stats { get => _stats; }

    public Resistances Resistances { get => _resistances; }

    public List<SkillBaseSO> SkillSet { get => _skillSet; }
    public int Hp { get => hp; }
    #endregion

    public Enemy(EnemyBaseSO enemyBase, int level)
    {
        _base = enemyBase;
        _level = level;

        var stats = new Stats(enemyBase, level);
        var resistances = enemyBase.Resistances[level];

        _stats = stats;
        _resistances = resistances;

        var skillSet = new List<SkillBaseSO>();

        foreach (EnemySkillDatabase skill in enemyBase.SkillSet)
        {
            skillSet.Add(skill.SkillDatabase[level]);
        }

        _skillSet = skillSet;
        hp = stats.MaxHP;
    }
}

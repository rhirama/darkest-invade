using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Enemy
{
    [SerializeField] private EnemyBase _base;
    [SerializeField][Range(0, 2)] private int _level;
    [SerializeField] private SkillSetBase _skillSet;

    private Stats _stats;
    private Resistances _resistances;
    public EnemyBase Base { get => _base; }
    public int Level { get => _level; }
    public Stats Stats { get => _stats; }
    public Resistances Resistances { get => _resistances; }
    public SkillSetBase SkillSet { get => _skillSet; }

    public Enemy(EnemyBase enemyBase, int level)
    {
        _base = enemyBase;
        _level = level;

        var stats = new Stats(enemyBase, level);
        var resistances = enemyBase.Resistances[level];

        _stats = stats;
        _resistances = resistances;

        var skillSet = enemyBase.SkillSets[level];

        _skillSet = skillSet;
    }
}

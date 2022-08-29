using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIEnemyPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI monsterName;
    [SerializeField] private TextMeshProUGUI hpCounter;
    [SerializeField] private TextMeshProUGUI monsterType;
    [SerializeField] private TextMeshProUGUI dodgeValue;
    [SerializeField] private TextMeshProUGUI speedValue;
    [SerializeField] private TextMeshProUGUI rStun;
    [SerializeField] private TextMeshProUGUI rBlight;
    [SerializeField] private TextMeshProUGUI rBleed;
    [SerializeField] private TextMeshProUGUI rMove;

    public void SetEnemyPanel(Enemy enemy)
    {
        monsterName.text = enemy.Base.EnemyName;
        monsterType.text = enemy.Base.EnemyType.ToString();
        hpCounter.text = $"{enemy.Hp} / {enemy.Stats.MaxHP}";
        dodgeValue.text = $"DODGE {enemy.Stats.Dodge}";
        speedValue.text = $"SPEED {enemy.Stats.Speed}";
        rStun.text = enemy.Resistances.Stun.ToString() + "%";
        rBlight.text = enemy.Resistances.Blight.ToString() + "%";
        rBleed.text = enemy.Resistances.Bleed.ToString() + "%";
        rMove.text = enemy.Resistances.Move.ToString() + "%";
    }

}

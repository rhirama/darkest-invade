using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] private int activeCharacter = 0;
    [SerializeField] private PartyUI partyUI;
    [SerializeField] private EnemyPartyUI enemyPartyUI;


    public int ActiveCharacter { get => activeCharacter; }

    public void SetBattle(PlayerPartyData playerData, EnemyPartyData enemyData)
    {
        partyUI.SetPartyUI(playerData);
        enemyPartyUI.SetEnemyPartyUI(enemyData);
        partyUI.SetSelectedUI(activeCharacter);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{
    [SerializeField] private List<HeroBaseSO> _base;
    [SerializeField][Range(1, 5)] private int resolveLevel;
    [SerializeField][Range(1, 5)] private int weaponLevel;
    [SerializeField][Range(1, 5)] private int armorLevel;
    [SerializeField] private List<string> heroNames;
    [SerializeField] private BattleHudManager battleHudManager;
    [SerializeField] private BattleSystem battleSystem;
    [SerializeField] private PartyUI partyUI;
    [SerializeField] private PlayerPartyData partyData;

    //Enemy status
    [SerializeField] private List<EnemyBaseSO> enemyBases;
    [SerializeField] private int enemyLevel;
    [SerializeField] private EnemyPartyData enemyPartyData;
    [SerializeField] private EnemyPartyUI enemyPartyUI;
    //Setup


    [SerializeField] private UIEnemyPanel enemyPanel;

    private void Start()
    {
        HandleUpdate();

    }

    public void HandleUpdate()
    {
        partyData.Party = new List<Hero>(0);
        
        for (int i = 0; i < 4; i++) 
        {

            partyData.Party.Add(new Hero(_base[i], resolveLevel, weaponLevel, armorLevel, heroNames[i]));
        }
        
        enemyPartyData.Party = new List<Enemy>(0);
        
        for (int i = 0; i < 4; i++) 
        {
            enemyPartyData.Party.Add(new Enemy(enemyBases[i], enemyLevel));
        }

        battleSystem.SetBattle(partyData, enemyPartyData);

    }


}

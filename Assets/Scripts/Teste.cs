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
    [SerializeField] private HeroPanelUI heroPanel;
    [SerializeField] private BanerPanelUI banerPanel;
    [SerializeField] private PartyUI partyUI;
    [SerializeField] private PlayerPartyData partyData;

    //Enemy status
    [SerializeField] private List<EnemyBase> enemyBases;
    [SerializeField] private int enemyLevel;
    [SerializeField] private EnemyPartyData enemyPartyData;
    [SerializeField] private EnemyPartyUI enemyPartyUI;
    


    private void Start() {
        HandleUpdate();

    }

    public void HandleUpdate() {

        partyData.Party = new List<Hero>(0);
        
        for (int i = 0; i < 4; i++) {

            partyData.Party.Add(new Hero(_base[i], resolveLevel, weaponLevel, armorLevel, heroNames[i]));

        }
        
        partyUI.SetPartyUI(partyData);

        heroPanel.SetHeroPanel(partyData.Party[0]);
        banerPanel.SetBanerPanel(partyData.Party[0]);

        enemyPartyData.Party = new List<Enemy>(0);
        
        for (int i = 0; i < 4; i++) {

            enemyPartyData.Party.Add(new Enemy(enemyBases[i], enemyLevel));
            Debug.Log(enemyPartyData.Party.Count);

        }
        Debug.Log(enemyPartyData.Party[0].Stats.MaxHP);
        enemyPartyUI.SetEnemyPartyUI(enemyPartyData);
        

    }

}

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

    private void Start() {
        HandleUpdate();

    }

    public void HandleUpdate() {

        partyData.Party = new List<Hero>(4);
        
        for (int i = 0; i < 4; i++) {

            partyData.Party.Add(new Hero(_base[i], resolveLevel, weaponLevel, armorLevel, heroNames[i]));

        }
        
        partyUI.SetPartyUI(partyData);
        

    }

}

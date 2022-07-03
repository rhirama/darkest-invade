using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyUI : MonoBehaviour
{
    [SerializeField] private List<HeroUI> party;
    [SerializeField] private int selected = 0; 
    [SerializeField] private PlayerPartyData partyData;
    [SerializeField] private HeroPanelUI heroPanel;
    [SerializeField] private BanerPanelUI banerPanel;


    public void SetPartyUI (PlayerPartyData partyData) {

        int i=0;
        
        foreach(Hero hero in partyData.Party) {
            
            party[i].SetHeroUI(hero);

            i++;
        }

    }

    public void SetSelectedUI(int selected) {

        banerPanel.SetBanerPanel(partyData.Party[selected]);
        heroPanel.SetHeroPanel(partyData.Party[selected]);
    } 

}

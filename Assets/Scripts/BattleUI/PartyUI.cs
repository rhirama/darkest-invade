using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyUI : MonoBehaviour
{
    [SerializeField] private List<HeroUI> party;
    [SerializeField] private BattleHudManager battleHudManager;


    public void SetPartyUI (PlayerPartyData partyData) {

        int i=0;
        
        foreach(Hero hero in partyData.Party) 
        {
            party[i].SetHero(hero);
            i++;
        }

    }

    public void SetSelectedUI(int selected) {

        for (int i = 0; i < 4; i++)
        {
            if (i != selected)
            {
                party[i].NotSelected();
            }
            else
            {
                battleHudManager.SetHud(party[selected]);
                party[selected].Selected();
            }
        }
        
    } 

}
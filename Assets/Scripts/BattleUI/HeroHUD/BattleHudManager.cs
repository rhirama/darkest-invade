using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHudManager : MonoBehaviour
{
    [SerializeField] private HeroPanelUI heroPanel;
    [SerializeField] private BanerPanelUI banerPanel;
    [SerializeField] private MapPanelUI mapPanel;
    [SerializeField] private InventoryPanelUI inventoryPanel;
    [SerializeField] private PartyUI partyUI;

    [SerializeField] private State state;
    private enum State { inventory, map};

    public void SetHud(HeroUI heroUI)
    {
        heroPanel.SetHeroPanel(heroUI.Hero);
        banerPanel.SetBanerPanel(heroUI.Hero);

        switch (state)
        {
            case (State.inventory):
                InventorySwitch();
                break;
            case (State.map):
                MapSwitch();
                break;
        }
        
    }

    private void MapSwitch()
    {
        mapPanel.gameObject.SetActive(true);
        inventoryPanel.gameObject.SetActive(false);
    }

    private void InventorySwitch()
    {
        mapPanel.gameObject.SetActive(false);
        inventoryPanel.gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{
    [SerializeField] public Hero testHero;
    [SerializeField] private HeroBaseSO _base;
    [SerializeField][Range(1, 5)] private int resolveLevel;
    [SerializeField][Range(1, 5)] private int weaponLevel;
    [SerializeField][Range(1, 5)] private int armorLevel;
    [SerializeField] private string heroName;
    [SerializeField] private HeroPanelUI heroPanel;
    [SerializeField] private BanerPanelUI banerPanel;

    private SpriteRenderer image;

    private void Start()
    {
        HandleUpdate();
    }

    public void HandleUpdate()
    {
        testHero = new Hero(_base, resolveLevel, weaponLevel, armorLevel, heroName);

        heroPanel.SetHeroPanel(testHero);
        banerPanel.SetBanerPanel(testHero);
    }

}

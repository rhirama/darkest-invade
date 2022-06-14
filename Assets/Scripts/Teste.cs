using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{
    [SerializeField] Hero testHero;
    [SerializeField] private HeroBase _base;
    [SerializeField][Range(1, 5)] private int resolveLevel;
    [SerializeField][Range(1, 5)] private int weaponLevel;
    [SerializeField][Range(1, 5)] private int armorLevel;

    [SerializeField] private HeroPanelUI heroPanel;

    private SpriteRenderer image;

    private void Start()
    {
        HandleUpdate();
    }

    public void HandleUpdate()
    {
        testHero = new Hero(_base, resolveLevel, weaponLevel, armorLevel);

        heroPanel.SetHeroPanel(testHero);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HeroUI : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Image heroSprite;
    [SerializeField] private GameObject selectedIcon;
    [SerializeField] private BattleSystem battleSystem;
    [SerializeField] private int slot;
    private Hero _hero;

    public Hero Hero { get => _hero; }

    public void SetHero (Hero hero) 
    {
        heroSprite.sprite = hero.Base.BaseSprite;
        _hero = hero;
    }

    public void Selected () 
    {
        selectedIcon.SetActive(true);
    }

    public void NotSelected () 
    {
        selectedIcon.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        battleSystem.ChangeActiveCharacter(slot);
    }
}

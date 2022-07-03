using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class HeroUI : MonoBehaviour , IPointerDownHandler , IPointerUpHandler
{
    [SerializeField] private Image heroSprite;
    [SerializeField] private GameObject selectedIcon;

    public void OnPointerDown(PointerEventData eventData)
    {
        Selected();
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        NotSelected();
    }




    public void SetHeroUI (Hero hero) {
        heroSprite.sprite = hero.Base.BaseSprite;

    }

    public void Selected () {

        selectedIcon.SetActive(true);

    }

    public void NotSelected () {

        selectedIcon.SetActive(false);

    }
    
}

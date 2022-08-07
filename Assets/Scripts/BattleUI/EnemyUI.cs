using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class EnemyUI : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler {

    [SerializeField] private Image enemySprite;
    [SerializeField] private GameObject selectedIcon;

    public void SetEnemyUI (Enemy enemy){

        enemySprite.sprite = enemy.Base.BaseSprite;
    }
    

    public void OnPointerEnter (PointerEventData eventData) {

        selectedIcon.SetActive(true);

    }

    public void OnPointerExit (PointerEventData eventData) {

        selectedIcon.SetActive(false);

    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;




public class EnemyUI : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler {

    [SerializeField] private Image enemySprite;
    [SerializeField] private GameObject selectedIcon;
    [SerializeField] private UIEnemyPanel enemyPanel;
    [SerializeField] private Enemy _enemy;

    public Enemy Enemy { get => _enemy; }

    public void SetEnemyUI (Enemy enemy)
    {
        enemySprite.sprite = enemy.Base.BaseSprite;
        _enemy = enemy;
    }
    

    public void OnPointerEnter (PointerEventData eventData) 
    {
        selectedIcon.SetActive(true);
        enemyPanel.gameObject.SetActive(true);
        enemyPanel.SetEnemyPanel(_enemy);
    }

    public void OnPointerExit (PointerEventData eventData) 
    {
        selectedIcon.SetActive(false);
        enemyPanel.gameObject.SetActive(false);
    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class WeaponHUD : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    [SerializeField] private HeroPanelUI heroPanel;

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        DescriptionBoxSystem.Show(
            
            $"{heroPanel.HeroSelected.Weapon.Name}"+
            $"\nDMG base: {heroPanel.HeroSelected.Weapon.MinDamage} - {heroPanel.HeroSelected.Weapon.MaxDamage}"+
            $"\nCRIT base: {heroPanel.HeroSelected.Weapon.Crit} %"+
            $"\nSPD base: {heroPanel.HeroSelected.Weapon.Speed}",
            this.GetComponent<RectTransform>()
        );

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionBoxSystem.Hide();
    }
}

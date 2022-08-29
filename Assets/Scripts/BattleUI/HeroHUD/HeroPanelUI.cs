using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class HeroPanelUI : MonoBehaviour
{
    [SerializeField] private Image weaponIcon;
    [SerializeField] private TextMeshProUGUI weaponLevelText;
    [SerializeField] private Image armorIcon;
    [SerializeField] private TextMeshProUGUI armorLevelText;
    [SerializeField] private List<TextMeshProUGUI> statsText;
    [SerializeField] private TextMeshProUGUI hpCounter;
    [SerializeField] private TextMeshProUGUI stressCounter;

    //==============================================================================
    //                                 Tooltips
    //==============================================================================

    [SerializeField] private DescritptionBoxTrigger weapon;


    private Hero heroSelected;

    public Hero HeroSelected { get => heroSelected; }


    public void SetHeroPanel(Hero hero)
    {
        armorIcon.sprite = hero.Base.Armors.ArmorSet[hero.ArmorLevel - 1].Icon;
        weaponIcon.sprite = hero.Base.Weapons.WeaponSet[hero.WeaponLevel - 1].Icon;

        weaponLevelText.text = hero.WeaponLevel.ToString();
        armorLevelText.text = hero.ArmorLevel.ToString();

        hpCounter.text = $"{hero.Hp} / {hero.Stats.MaxHP}";
        stressCounter.text = $"{hero.Stress} / 200";

        statsText[0].text = $"ACC   {hero.Stats.AccMod}";
        statsText[1].text = $"CRIT  {hero.Stats.Crit}";
        statsText[2].text = $"DMG   {hero.Stats.MinDamage}-{hero.Stats.MaxDamage}";
        statsText[3].text = $"DODGE {hero.Stats.Dodge}";
        statsText[4].text = $"PROT  {hero.Stats.Prot}";
        statsText[5].text = $"SPD   {hero.Stats.Speed}";

        heroSelected = hero;

        SetTooltips(hero);
    }

    public void SetTooltips(Hero hero)
    {
        weapon.SetTooltipObject(hero.Weapon);
    }

}

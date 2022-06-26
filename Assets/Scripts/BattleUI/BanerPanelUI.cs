using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BanerPanelUI : MonoBehaviour
{
    [SerializeField] private Image heroIcon;
    [SerializeField] private Image skillIcon1;
    [SerializeField] private Image skillIcon2;
    [SerializeField] private Image skillIcon3;
    [SerializeField] private Image skillIcon4;
    [SerializeField] private TextMeshProUGUI heroName;
    [SerializeField] private TextMeshProUGUI heroJob;


    public void SetBanerPanel(Hero hero)
    {
        heroIcon.sprite = hero.Base.Icon;
        skillIcon1.sprite = hero.SkillSet[0].Icon;
        skillIcon2.sprite = hero.SkillSet[1].Icon;
        skillIcon3.sprite = hero.SkillSet[2].Icon;
        skillIcon4.sprite = hero.SkillSet[3].Icon;

        heroName.text = hero.Name;
        heroJob.text = hero.Base.Job.ToString();

    }
}

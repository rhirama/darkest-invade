using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DescritptionBoxTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private string text;
    [SerializeField] private IHaveTooltip tooltip;
    [SerializeField] private bool useObject = false;



    public void OnPointerEnter(PointerEventData eventData)
    {
        if (useObject)
        {
            DescriptionBoxSystem.Show(tooltip.BuildTooltipText(), this.GetComponent<RectTransform>());
        }
        else
        {
            DescriptionBoxSystem.Show(text, this.GetComponent<RectTransform>());
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionBoxSystem.Hide();
    }

    public void SetTooltipObject(IHaveTooltip newTooltip)
    {
        tooltip = newTooltip;
        useObject = true;
    }

    public void SetTooltipText(string newText)
    {
        text = newText;
        useObject = false;
    }

}

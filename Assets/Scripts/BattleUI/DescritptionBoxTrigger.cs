using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DescritptionBoxTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private string text;

    public void OnPointerEnter(PointerEventData eventData)
    {
        DescriptionBoxSystem.Show(text);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DescriptionBoxSystem.Hide();
    }
}

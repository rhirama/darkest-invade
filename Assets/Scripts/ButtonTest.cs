using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTest : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] Teste teste;

    public void OnPointerDown(PointerEventData eventData)
    {
        teste.HandleUpdate();
        teste.testHero.CheckSkills();
    }
}

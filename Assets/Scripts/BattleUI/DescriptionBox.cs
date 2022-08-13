using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DescriptionBox : MonoBehaviour
{
    private static DescriptionBox instance;

    [SerializeField]private Camera uiCamera;
    private RectTransform boxPosition; 
    [SerializeField] TextMeshProUGUI textBox;
    [SerializeField] string stringDeTest;
    [SerializeField] LayoutElement layoutElement;
    [SerializeField] private int characterWrapLimit;

    private void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
        boxPosition = GetComponent<RectTransform>();

    }

    private void Update()
    {
        

        //Vector2 localPoint;
        //RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        //boxPosition.localPosition = localPoint;

    }

    public void SetText(string text)
    {
        textBox.text = text;
        int contentLenght = textBox.text.Length;

        layoutElement.enabled = (contentLenght > characterWrapLimit) ? true : false;

    }


}

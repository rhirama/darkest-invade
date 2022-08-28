using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DescriptionBox : MonoBehaviour
{
    [SerializeField]private Camera uiCamera;
    private RectTransform boxPosition; 
    [SerializeField] TextMeshProUGUI textBox;
    [SerializeField] string stringDeTest;
    [SerializeField] LayoutElement layoutElement;
    [SerializeField] private int characterWrapLimit;

    private void Awake()
    {
        boxPosition = GetComponent<RectTransform>();
    }

    private void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        boxPosition.localPosition = localPoint;
    }

    public void SetText(string text = null, IHaveTooltip obj = null )
    {
        if (obj != null)
        {
            textBox.text = obj.BuildTooltipText();
        }
        else if (text != null)
        {
            textBox.text = text;
        }
        else
        {
            textBox.text = "";
        }

        int contentLenght = textBox.text.Length;
        layoutElement.enabled = (contentLenght > characterWrapLimit) ? true : false;

    }

    public void SetPosition(RectTransform obj, bool left )
    {
        //boxPosition.localPosition = obj.transform.position;
    }


}

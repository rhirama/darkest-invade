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

    private void Start()
    {
        
    }
    private void Awake()
    {
        instance = this;
        boxPosition = GetComponent<RectTransform>();

        ShowBox("string\r\n" +
            "de\r\n" +
            "teste\r\n");
    }

    private void Update()
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(transform.parent.GetComponent<RectTransform>(), Input.mousePosition, uiCamera, out localPoint);
        boxPosition.localPosition = localPoint;
    }

    public void ShowBox(string text)
    {
        gameObject.SetActive(true);
        textBox.text = text;
    }

    public void HideBox()
    {
        gameObject.SetActive(false);
    }

    public static void ShowBox_Static(string text)
    {
        instance.ShowBox(text);
    }

    public static void HideBox_Static()
    {
        instance.HideBox();
    }
}

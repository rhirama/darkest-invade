using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionBoxSystem : MonoBehaviour
{

    private static DescriptionBoxSystem current;

    [SerializeField] private DescriptionBox descriptionBox;

    private void Awake()
    {
        current = this;
    }

    public static void Show(string text, RectTransform obj)
    {
        current.descriptionBox.SetText(text);
        current.descriptionBox.gameObject.SetActive(true);
        current.descriptionBox.SetPosition(obj, true);
    }

    public static void Hide()
    {
        current.descriptionBox.gameObject.SetActive(false);
    }
}

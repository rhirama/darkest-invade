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

    public static void Show(string text)
    {
        current.descriptionBox.SetText(text);
        current.descriptionBox.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        current.descriptionBox.gameObject.SetActive(false);
    }
}

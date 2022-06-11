using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teste : MonoBehaviour
{
    [SerializeField] Hero testHero;
    [SerializeField] private HeroBase _base;
    [SerializeField][Range(1, 5)] private int resolveLevel;
    [SerializeField][Range(1, 5)] private int weaponLevel;
    [SerializeField][Range(1, 5)] private int armorLevel;
    private SpriteRenderer image;

    // Start is called before the first frame update
    void Start()
    {
        testHero = new Hero(_base, resolveLevel, weaponLevel, armorLevel);

        image = GetComponent<SpriteRenderer>();

        Debug.Log(testHero.ResolveLevel);
        image.sprite = testHero.Base.BaseSprite;

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}

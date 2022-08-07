using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPartyData : MonoBehaviour
{
    [SerializeField] private List<Enemy> party;

    public List<Enemy> Party { get; set; }
}

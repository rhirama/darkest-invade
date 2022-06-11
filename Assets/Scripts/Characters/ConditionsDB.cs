using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsDB : MonoBehaviour
{
    public static Dictionary<ConditionID, Condition> Conditions { get; set; } = new Dictionary<ConditionID, Condition>()
    { };

}

public enum ConditionID
{
    Bleed, Blight
}
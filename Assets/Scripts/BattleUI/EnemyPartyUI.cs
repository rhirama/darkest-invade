using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPartyUI : MonoBehaviour
{
    [SerializeField] private List<EnemyUI> enemyParty;
    [SerializeField] private EnemyPartyData enemyPartyData;


    public void SetEnemyPartyUI (EnemyPartyData enemyPartyData) {

        int i=0;

        foreach(Enemy enemy in enemyPartyData.Party) {
            
            enemyParty[i].SetEnemyUI(enemy);

            i++;
        }
    }
}

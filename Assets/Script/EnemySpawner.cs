using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefab;

    Enemy enemy; //출현 중인 적 보유

    public void Spawn()
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public float spawnInterval = 3f; // 적 출현 간격

    EnemySpawner[] spawners;
    float timer = 1f; // 출현 시간 판정용 타이머 변수

    // Start is called before the first frame update
    void Start()
    {
        //EnemySpawner 리스트 취득
        spawners = GetComponentsInChildren<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(spawnInterval < timer)
        {
            // 랜덤으로 EnemySpawne를 선택해서 적 출현 
            var index = Random.Range(0, spawners.Length);
            spawners[index].Spawn();

            timer = 0;
        }
    }
}

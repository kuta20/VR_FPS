using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform[] EnemySpawner; // 적 출현 위치 리스트 
    public GameObject EnemyPrefab; // 적 프리팹 변수

    public float createTime; // 생성시간
    private int maxEnemy = 5; // 최대 적 개수
    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // SpawnerManger를 찾아 하위에 있는 모든 transform을 가져오기
        EnemySpawner = GameObject.Find("SpawnerManger").GetComponentsInChildren<Transform>();

        if (EnemySpawner.Length > 0)
        {
            StartCoroutine(this.CreateEnemy());
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateEnemy()
    {
        while (!isGameOver)
        {
            int enemyCount = (int)GameObject.FindGameObjectsWithTag("Enemy").Length;

            if(enemyCount < maxEnemy)
            {
                yield return new WaitForSeconds(createTime); // 적 생성주기 시간만큼 대기

                int idx = Random.Range(1, EnemySpawner.Length); // 랜덤 위치 

                // 스폰
                Instantiate(EnemyPrefab, EnemySpawner[idx].position,EnemySpawner[idx].rotation);
            }else
            {
                yield return null;
            }
        }
    }
}

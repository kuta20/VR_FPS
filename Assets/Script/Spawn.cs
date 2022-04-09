using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ZomBearPrefabs;
    public int crateZomeprefabs;
    public float countTime;

    // Start is called before the first frame update
    void Start()
    {
        countTime += Time.deltaTime;
        if(countTime > 5.0)
        {
            if(crateZomeprefabs < 6)
            {
                Vector3 pos = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));

                Instantiate(ZomBearPrefabs, transform.position, Quaternion.identity);
                crateZomeprefabs++;
                countTime = 0f;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

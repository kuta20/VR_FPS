using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update

    private float lifetime = 1f;
    void Start()
    {
        // 총알을 앞쪽 방향으로 속도 백터 계산 
        var velocity = speed * transform.forward;

        //Rigidbody 가져오기
        var rigidbody = GetComponent<Rigidbody>();

        // rigidbody 활용해 사격 속도 조절 
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);

        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

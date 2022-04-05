using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update

    // 총알 제거 시간 
    private float lifetime = 1f;
    void Start()
    {
        // 앞쪽 방향의 속도 벡터 계산
        var velocity = speed * transform.forward;

        // rigidbody 가져오기
        var rigidbody = GetComponent<Rigidbody>();

        // rigidbody 사용해 시작 속도 준다.
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);

        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 피격 대상 메세지 
        other.SendMessage("OnHitBullet");

        //자신 오브젝트 제거
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefabs; 
    public Transform gunBurrelEnd;

    [SerializeField] ParticleSystem gunEffect;
    [SerializeField] AudioSource gunAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefabs, gunBurrelEnd.position, gunBurrelEnd.rotation);

        gunEffect.Play();
        gunAudioSource.Play();
    }
}

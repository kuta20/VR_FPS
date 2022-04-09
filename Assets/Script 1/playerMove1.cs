using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove1 : MonoBehaviour
{
    public float speed = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        float f = Input.GetAxis("Horizontal_2");
        float V = Input.GetAxis("Vertical_2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour
{
    [SerializeField]
    float angularVelocity = 1000.0f;
    [SerializeField]
    float minAngle, maxAngle;
    float horizontalAngle = 0;
    float verticalAngle = 0;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        var horizontalRotation = Input.GetAxis("Mouse X") * angularVelocity * Time.deltaTime;
        var verticalRotation = Input.GetAxis("Mouse Y") * angularVelocity * Time.deltaTime;

        horizontalAngle += horizontalRotation;
        verticalAngle += verticalRotation; 

        //horizontalAngle = Mathf.Clamp(horizontalAngle, -minAngle, maxAngle);
        verticalAngle = Mathf.Clamp(verticalAngle, minAngle, maxAngle);
        transform.rotation = Quaternion.Euler(-verticalAngle, horizontalAngle, 0);

    }
}

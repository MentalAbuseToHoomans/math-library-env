using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveWithMouse : MonoBehaviour
{
    
    [SerializeField] Transform transTarget;
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;

    private void Awake()
    {
        transTarget = GameObject.Find("obj_player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transTarget.position;
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Serialize Field lets variables made here become modifiable in unity editor
    [SerializeField] Vector3 v3XForce = new Vector3(0.175f, 0, 0);
    [SerializeField] Vector3 v3ZForce = new Vector3(0, 0, 0.175f);
    KeyCode keyPositive = KeyCode.D;
    KeyCode keyNegative = KeyCode.A;
    KeyCode keyForward = KeyCode.W;
    KeyCode keyBackward = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //Fixed is 100fps default, change in editor later
    {
        if (Input.GetKey(keyPositive)) 
        {
            GetComponent<Rigidbody>().velocity += v3XForce;
        }

        if (Input.GetKey(keyNegative))
        {
            GetComponent<Rigidbody>().velocity -= v3XForce;
        }

        if (Input.GetKey(keyForward)) 
        {
            GetComponent<Rigidbody>().velocity += v3ZForce;
        }

        if (Input.GetKey(keyBackward))
        {
            GetComponent<Rigidbody>().velocity -= v3ZForce;
        }

    }
}

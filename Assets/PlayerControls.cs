using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    
    public float movementSpeed = 0.1f;
    public float jumpForce = 5;
    public int maxJumps = 1;

    int hasJump;
    Rigidbody rb;

    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.D) )
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;

        }

        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            hasJump = maxJumps;
        }
    }

}

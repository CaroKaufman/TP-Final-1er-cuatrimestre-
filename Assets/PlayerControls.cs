using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerControls : MonoBehaviour
{
    //Audio
    public AudioClip jumpSound;
    AudioSource fuenteAudio;
    public AudioClip biteSound;

    public float movementSpeed = 0.1f;
    public float jumpForce = 1;
    public int maxJumps = 1;
    int hasJump;
    Rigidbody rb;


    void Start()
    {
        
        fuenteAudio = GetComponent<AudioSource>();
        
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
            fuenteAudio.clip = jumpSound;
            fuenteAudio.Play();

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
        if (col.gameObject.tag == "Comida")
        {
            fuenteAudio.clip = biteSound;
            fuenteAudio.Play();

        }
        

    }
    

}

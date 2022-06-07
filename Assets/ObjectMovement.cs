using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float xSpeed = 0.03f;
    public float xRightLimit = 0.5f;
    public float xLeftLimit = -2f;
    public bool toRight;
       
    

    void Start()
    {
        toRight = true;
        
    }

        void Update()
    {
        if (toRight) 
        {
           
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else if (toRight == false)
        {
            
           transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xRightLimit)
        {
            toRight = false;
        }
        else if(transform.position.x <= xLeftLimit)
        {
            toRight = true;
        }
    }

    
}

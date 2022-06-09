using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoves : MonoBehaviour
{
    public float xSpeed = 0.03f;
    public bool waited;
    public bool toRight;
    // public float xLeftLimit = -4f;
    // public float xRightLimit = 4f;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
        waited = true;
       
    }

    // Update is called once per frame
    void Update()
    {   
      
            if(toRight)
            {
                transform.position += new Vector3(xSpeed, 0, 0);            
            }            
            else
            {
                transform.position -= new Vector3(xSpeed, 0, 0);
            }            
         

        if(transform.position.x < -1.65f){
            toRight = true;
            StartCoroutine(Wait(5));
        }else if (transform.position.x > 0.35f){
            toRight = false;
            StartCoroutine(Wait(5));
        }
      
      
    }

    IEnumerator Wait(int num){
        xSpeed = 0f;
        yield return new WaitForSeconds(num);
        xSpeed = 0.03f;
    }


}

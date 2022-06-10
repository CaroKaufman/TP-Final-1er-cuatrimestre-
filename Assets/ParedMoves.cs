﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedMoves : MonoBehaviour
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
             //Si espera 5 segundos el cubo va para adelante
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
            StartCoroutine(Wait());
            
        }
        else if (transform.position.x > 0.35f){
            toRight = false;
            StartCoroutine(Wait());
            
        }
      
      
    }

    IEnumerator Wait(){
        xSpeed = 0f;
        yield return new WaitForSeconds(5);
        xSpeed = 0.03f;
    }
}
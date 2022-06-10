using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount =  2;
    GameObject clon;
    public GameObject Player;
    
    

    void Start()
    {
        //StartCoroutine(Wait(5));
    }
    
    void Update()
    {

        

    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathFloor"  && Player.name == "Player")
        {
            
            
            for (int i = 0; i< cloneAmount; i++)
            {
                clon = Instantiate(objectToClone);
                Destroy(clon,3);
            }
        
            transform.position = new Vector3(0,1,0);
             
                     
            
        }  
             

    }
    
}

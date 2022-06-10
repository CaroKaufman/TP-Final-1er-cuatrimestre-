using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount =  5;
    GameObject clon;
  
    
    

    void Start()
    {
      
       
    }
    
    void Update()
    {

        

    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathFloor")
        {
                                 
            int counter = 0;
            for (int i = counter; i< cloneAmount; i++)
            {
                clon = Instantiate(objectToClone);
                                
            }
            StartCoroutine(Wait(3));
            Destroy(clon);
            

        }  
             

    }
    IEnumerator Wait(int num)
    {
        yield return new WaitForSeconds(num);
      

    }
}

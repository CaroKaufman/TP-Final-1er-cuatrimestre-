using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject objectToClone;
    int cloneAmount =  5;
    GameObject clon;
  

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathFloor")
        {
            clon = Instantiate(objectToClone);
            int counter = 0;
            for (int i = counter; i< cloneAmount; i++)
            {
                clon = Instantiate(objectToClone);
                Destroy(clon);
                transform.position = new Vector3(0, 1, 0);
            }
            
        }  
             

    }
}

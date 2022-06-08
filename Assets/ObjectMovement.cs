using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float xSpeed = 0.03f;
    public float xRightLimit = 4f;
    public float xLeftLimit = -4f;
    public bool toRight;
    public GameObject[] cubos;
    public int elegirNum;
    public bool WaitMove;

    void Start()
    {
        toRight = true;
        WaitMove = true;
       //StartCoroutine(MoviendoCubos());
    }

        void Update()
    {
        elegirNum = Random.Range(0,5);
        GameObject cuboseleccionado = cubos[elegirNum];
                    
         if (toRight) 
         {
             
           cuboseleccionado.transform.position += new Vector3(xSpeed, 0, 0);

         }
         else 
         {
            
           cuboseleccionado.transform.position -= new Vector3(xSpeed, 0, 0);
         }
         if (cuboseleccionado.transform.position.x >= xRightLimit)
         {
             toRight = false;
             
         }
         else if (cuboseleccionado.transform.position.x <= xLeftLimit)
         {
             toRight = true;
         }
        
       
    }
 
 //  IEnumerator MoviendoCubos() {
    

 //  }
    

}

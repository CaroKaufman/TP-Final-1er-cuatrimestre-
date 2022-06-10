using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMoves : MonoBehaviour
{
    public float xSpeed = 0.03f;
    
    public bool toLeft;

    public GameObject[] cubito;
    public int ElegirNum;
    public GameObject elegido;

    // Start is called before the first frame update
    void Start()
    {
        toLeft = true;
        

        StartCoroutine(Espera());

    }

    // Update is called once per frame
    void Update()
    {
        elegido = cubito[ElegirNum];
        //Elige un cubo. Hace el loop. Elige otro cubo


        if (toLeft)
        {
            xSpeed = 0.03f;
            elegido.transform.position -= new Vector3(xSpeed, 0, 0);
            
        }
        else
        {
            elegido.transform.position += new Vector3(xSpeed, 0, 0);
        }


        if (elegido.transform.position.x > 0.35f)//-3.000055 
        {

            StartCoroutine(Espera());
            toLeft = true;

        }
        else if (elegido.transform.position.x < -1.65f)
        {
            toLeft = false;
            StartCoroutine(Wait());

        }


    }

    IEnumerator Wait()
    {
        xSpeed = 0f;
        yield return new WaitForSeconds(5);
        xSpeed = 0.03f;
    }
    IEnumerator Espera()
    {
        xSpeed = 0f;

        ElegirNum = Random.Range(0, 5);
        yield return new WaitForSeconds(2);

    }
}

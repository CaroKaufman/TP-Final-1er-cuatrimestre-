using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedMoves : MonoBehaviour
{
    public float xSpeed = 0.03f;
    public bool waited;
    public bool toRight;

    public GameObject[] cubito;
    public int ElegirNum;
    public GameObject elegido;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
        waited = true;

        StartCoroutine(Espera());

    }

    // Update is called once per frame
    void Update()
    {
        elegido = cubito[ElegirNum];
        //Elige un cubo. Hace el loop. Elige otro cubo


        if (toRight)
        {
            xSpeed = 0.03f;
            elegido.transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            elegido.transform.position -= new Vector3(xSpeed, 0, 0);
        }


        if (elegido.transform.position.x < -1.65f)//-3.000055 
        {

            StartCoroutine(Espera());
            toRight = true;

        }
        else if (elegido.transform.position.x > 0.35f)
        {
            toRight = false;
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

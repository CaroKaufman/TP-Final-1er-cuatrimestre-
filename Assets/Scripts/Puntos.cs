using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    //Puntos
    public Text txtPuntos;

    

    public int counter=0;
    public int puntos=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter == 1)
        {
            //txtPuntos = gameObject.GetComponent<Text>();
            txtPuntos.text = ":" + puntos;
            counter--;
        }
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Comida")
        {
            
            puntos++;
            counter++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Comida : MonoBehaviour
{
    public GameObject comidaPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        //La esfera toca al Player, cambia de posicion random en el eje z
        if (col.gameObject.name == "Player")
        {
            
            Destroy(comidaPrefab);
            Vector3 randomSpawnPosition = new Vector3(0.6f, 0.43f, Random.Range(-4.16f, 4.17f));
            Instantiate(comidaPrefab, randomSpawnPosition, Quaternion.identity);
                        
        }
    }
}

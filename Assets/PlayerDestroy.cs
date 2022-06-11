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
    bool waited;
    bool die;
    

    //Audio
    public AudioClip dieSound;
    AudioSource fuenteAudio;

    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
      
        waited = false;
        die = false;
    }
    
    void Update()
    {
        if (die)
        {
            StartCoroutine(WaitReset());
            if (waited)
            {
              transform.position = new Vector3(0, 1, 0);
              transform.rotation = Quaternion.Euler(0, 0, 0);
              
            }
        }
        

    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "DeathFloor"  && Player.name == "Player")
        {
            

            for (int i = 0; i< cloneAmount; i++)
            {
                clon = Instantiate(objectToClone);
                fuenteAudio.clip = dieSound;
                fuenteAudio.Play();           
                Destroy(clon,3);
                die = true;
            }
            

        }
        

    }
    IEnumerator WaitReset()
    {
    
        yield return new WaitForSeconds(5);
        waited = true;

    }
}

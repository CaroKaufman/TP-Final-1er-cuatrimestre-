using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{//https://www.youtube.com/watch?v=pvo0RCiqtLQ&t=181s
    public float speed= 1.0f;
    public Color startColor;
    public Color endColor;
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

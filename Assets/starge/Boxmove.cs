using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxmove : MonoBehaviour
{

    public float moveState;
    public float speed;
    Vector3 vector;

    void Start()
    {
        vector = transform.position;
    }


    void Update()
    {       
        float x = moveState * Mathf.Sin(Time.time * speed);
        transform.position = vector + new Vector3(x, 0, 0);
    }
}


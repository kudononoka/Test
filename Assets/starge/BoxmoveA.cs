using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxmoveA : MonoBehaviour
{
    public float moveState;
    public float speed;
    Vector3 vector;

    void Start()
    {
        vector = transform.localPosition;
    }


    void Update()
    {
        float z= moveState * Mathf.Sin(Time.time * speed);
        transform.localPosition = vector + new Vector3(0, 0, z);
    }
}

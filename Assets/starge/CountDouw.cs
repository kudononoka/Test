using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDouw : MonoBehaviour
{
    private float time = 3.0f;
    public bool isTimeUp;
    // Start is called before the first frame update
    void Start()
    {
        isTimeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(0 < time)
        {
            time -= Time.deltaTime;
        }
        else if (time < 0)
        {
            isTimeUp=true;
        }
    }
}

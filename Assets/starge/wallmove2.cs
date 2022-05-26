using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallmove2 : MonoBehaviour
{
    private float move = 0.03f;
    public GameObject timeUp;
    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        if(timeUp.GetComponent<CountDouw>().isTimeUp == false)
        {
            Vector3 p = new Vector3(move, 0,0);
            transform.Translate(p);
        }
    }
}

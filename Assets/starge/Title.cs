using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool firstPush = false;
    //startbutton
    public void PressStart()
    {
        Debug.Log("Start!");

        if(!firstPush)
        {
            Debug.Log("Go Next Scene!");
            firstPush = true;
            SceneManager.LoadScene("SampleScene");
        }
    }
}

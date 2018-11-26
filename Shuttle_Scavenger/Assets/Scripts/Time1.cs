using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//shows level 1 time
public class Time1 : MonoBehaviour
{

    public Text text1;
    // Use this for initialization
    void Start()
    {
        Debug.Log(GameManager.time1);
        text1.text = GameManager.time1;
    }

}

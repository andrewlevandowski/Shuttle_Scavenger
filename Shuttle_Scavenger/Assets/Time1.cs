using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time1 : MonoBehaviour
{

    public Text text1;
    // Use this for initialization
    void Start()
    {
        text1.text = GameManager.Instance.time1;
    }

}

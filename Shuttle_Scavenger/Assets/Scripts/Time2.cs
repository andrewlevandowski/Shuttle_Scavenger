using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//shows level 2 time
public class Time2 : MonoBehaviour {

    public Text text2;
	// Use this for initialization
	void Start () {
        text2.text = GameManager.time2;
	}
	
}

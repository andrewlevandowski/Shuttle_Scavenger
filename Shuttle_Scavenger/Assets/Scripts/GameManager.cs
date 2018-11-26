using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//singleton manager script
//Singleton methods from GameDevHQ on Youtube https://youtu.be/EI1KJv8owCg
public class GameManager : MonoBehaviour {

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    //time objects for recording level times
    //victory and destroyed control the game's states
    static public string time1 { get; set; }
    static public string time2 { get; set; }
    public bool victory { get; set; }
    public bool destroyed { get; set; }

    void Awake()
    {
        _instance = this;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public string time1 { get; set; }
    public string time2 { get; set; }
    public bool victory { get; set; }
    public bool destroyed { get; set; }

    void Awake()
    {
        _instance = this;
    }
}

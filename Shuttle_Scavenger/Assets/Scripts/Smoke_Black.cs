using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke_Black : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ParticleSystem smoke = GetComponent<ParticleSystem>();
        var main = smoke.main;
        main.simulationSpeed = 3;
        smoke.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, 0, 0);
	}
}

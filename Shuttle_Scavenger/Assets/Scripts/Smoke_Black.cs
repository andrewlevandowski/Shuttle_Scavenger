using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//smoke controls for when you die
public class Smoke_Black : MonoBehaviour {

	//smoke is a little sped up
	void Start () {
        ParticleSystem smoke = GetComponent<ParticleSystem>();
        var main = smoke.main;
        main.simulationSpeed = 3;
        smoke.Stop();
    }
	
	//stops the smoke from rotating with the ship
	void Update () {
        transform.rotation = Quaternion.Euler(0, 0, 0);
	}
}

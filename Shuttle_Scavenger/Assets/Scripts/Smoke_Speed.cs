using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//controls smoke's speed and whether it's on
public class Smoke_Speed : MonoBehaviour {

    public KeyCode key1;
    public KeyCode key2;

    public float smoke_speed = 10;

    //changes smoke speed
	void Start () {
        ParticleSystem smoke = GetComponent<ParticleSystem>();
        var main = smoke.main;
        main.simulationSpeed = smoke_speed;
        smoke.Stop();
	}

    //determines what 2 keys trigger the smoke
    void Update()
    {
        if (GameManager.Instance.destroyed == false && GameManager.Instance.victory == false)
        {
            if (Input.GetKeyDown(key1) || Input.GetKeyDown(key2))
            {
                GetComponent<ParticleSystem>().Play();
            }

        }
        if (Input.GetKeyUp(key1) || Input.GetKeyUp(key2))
        {
            GetComponent<ParticleSystem>().Stop();
        }
    }
}

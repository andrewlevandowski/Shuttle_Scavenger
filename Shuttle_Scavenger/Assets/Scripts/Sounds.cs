using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

    AudioSource air_start;
    AudioSource explosion;
    AudioSource winner;
    private int counter;

    // Use this for initialization
    void Start () {
        var Audio = GetComponents<AudioSource>();
        air_start = Audio[0];
        explosion = Audio[1];
        winner = Audio[2];
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.destroyed == false)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)
                || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow)
                || Input.GetKeyDown(KeyCode.RightArrow))
            {
                air_start.Play();
            }
        } else
        {
            if (counter == 0)
            {
                explosion.Play();
                counter++;
            }
        }

        if (!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)
            || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow)
            || Input.GetKey(KeyCode.RightArrow)))
        {
            air_start.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Q))
            winner.Play();
    }
}

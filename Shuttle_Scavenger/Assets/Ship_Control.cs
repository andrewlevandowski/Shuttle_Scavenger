using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_Control : MonoBehaviour {

    [SerializeField]
    Vector3 velocity = Vector3.zero;
    [SerializeField]
    float accel = 10f;

    public float max_velocity;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //Forward and backgwards
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            velocity += transform.up * accel * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            velocity -= transform.up * accel * Time.deltaTime;

        }
        //turn left and right
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 70 * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -70 * Time.deltaTime));
        }

        //limit on speed
        if (velocity.x > max_velocity)
            velocity.x = max_velocity;
        if (velocity.x < -max_velocity)
            velocity.x = -max_velocity;
        if (velocity.y > max_velocity)
            velocity.y = max_velocity;
        if (velocity.y < -max_velocity)
            velocity.y = -max_velocity;

        //updates position
        transform.position += velocity;
	}
}

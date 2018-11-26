using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls for ship movement. all physics based
public class Ship_Control : MonoBehaviour {

    Rigidbody2D rb;

	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (GameManager.Instance.destroyed == false && GameManager.Instance.victory == false)
        {
            //Forward and backgwards
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddRelativeForce(new Vector2(0, 1.5f * Time.deltaTime), ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddRelativeForce(new Vector2(0, -1.5f * Time.deltaTime), ForceMode2D.Impulse);
            }
            //turn left and right
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddTorque(.5f * Time.deltaTime, ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddTorque(-.5f * Time.deltaTime, ForceMode2D.Impulse);
            }
        }
	}
}

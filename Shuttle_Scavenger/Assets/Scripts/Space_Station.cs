using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//catches collision for winning the level
public class Space_Station : MonoBehaviour {

    Rigidbody2D rb;
    Vector3 position;

    //"has been hit" or not
    bool hit;

    // Use this for initialization
    void Start()
    {
        //applies a torque to spin the structure
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddTorque(200f * Time.deltaTime, ForceMode2D.Impulse);
        position = transform.position;
        hit = false;
    }	

    void Update()
    {
        //as long as it hasn't been hit, keep the structure in one location
        if (hit == true)
            return;
        transform.position = position;
    }

    //collision sets off death
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ship")
            hit = true;
    }

}

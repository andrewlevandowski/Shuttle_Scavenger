using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Station : MonoBehaviour {

    Rigidbody2D rb;
    Vector3 position;
    bool hit;

    public float max_velocity;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddTorque(200f * Time.deltaTime, ForceMode2D.Impulse);
        position = transform.position;
        hit = false;
    }	

    void Update()
    {
        if (hit == true)
            return;
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ship")
            hit = true;
    }

}

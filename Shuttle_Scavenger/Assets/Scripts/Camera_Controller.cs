using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//matches camera location with ship
public class Camera_Controller : MonoBehaviour {

    public GameObject target;
    public float offset;
    public GameObject Wall_1;
    public GameObject Wall_2;

	// Use this for initialization
	void Start () {

    }

	// Update is called once per frame
	void Update () {

        //doesn't let camera go beyond certain point at edge of level
        if(((Wall_1.transform.position.x - target.transform.position.x) > 3) &&
            ((Wall_2.transform.position.x - target.transform.position.x) < -13))
            transform.position = new Vector3(target.transform.position.x + offset, transform.position.y, transform.position.z);

	}
}

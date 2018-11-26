using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//collision with winner object
public class Mineral_Collision : MonoBehaviour {

    //if collision is with ship, activate Winner() from LevelManager
	private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Ship")
            GameObject.Find("LevelManager").SendMessage("Winner");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mineral_Collision : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Ship")
            GameObject.Find("LevelManager").SendMessage("Winner");
    }
}

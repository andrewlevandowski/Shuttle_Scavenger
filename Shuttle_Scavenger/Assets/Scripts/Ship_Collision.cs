using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ship_Collision : MonoBehaviour {

    public ParticleSystem smoke_death;
    private SpriteRenderer spriteR;
    public Sprite destroyed_ship;

    // Use this for initialization

    void Start () {
        GameManager.Instance.destroyed = false;
        smoke_death.Stop();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle" && GameManager.Instance.victory == false)
        {
            Debug.Log("collision");
            smoke_death.Play();
            spriteR.sprite = destroyed_ship;
            GameManager.Instance.destroyed = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//controls and ship collision with death causing objects
public class Ship_Collision : MonoBehaviour {

    public ParticleSystem smoke_death;
    private SpriteRenderer spriteR;
    public Sprite destroyed_ship;


    void Start () {
        GameManager.Instance.destroyed = false;
        smoke_death.Stop();
        spriteR = gameObject.GetComponent<SpriteRenderer>();
	}

    //if collision is with "obstacle", die
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle" && GameManager.Instance.victory == false)
        {
            smoke_death.Play();
            spriteR.sprite = destroyed_ship;
            GameManager.Instance.destroyed = true;
        }
    }
}

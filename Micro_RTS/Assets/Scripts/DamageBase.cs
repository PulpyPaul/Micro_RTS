using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBase : Unit {

    public EndGame SliderManager;

    // Use this for initialization
    void Start () {
        health = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // On collision, destroy if the tag of the colliding object is unit
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag + " name: " + other.gameObject.name);
        if(other.tag == "unit" || other.tag == "eunit")
        {
            if (this.tag == "base" && health < 1)
                SliderManager.LoseGame();
            else if (this.tag == "enemyBase" && health < 1)
                SliderManager.WinGame();

            Debug.Log(this.tag + " health: " + health);

            //Destroy(other.gameObject);
        }
    }
}

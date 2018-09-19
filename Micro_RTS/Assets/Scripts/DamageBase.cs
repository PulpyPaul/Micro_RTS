using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBase : MonoBehaviour {

    private float baseHealth = 100;
    public EndGame SliderManager;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // On collision, destroy if the tag of the colliding object is unit
    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "unit" || other.tag == "eunit")
        {
            baseHealth -= 5;

            if (this.tag == "base" && baseHealth < 1)
                SliderManager.LoseGame();
            else if (this.tag == "enemyBase" && baseHealth < 1)
                SliderManager.WinGame();

            Debug.Log(this.tag + " health: " + baseHealth);

            Destroy(other.gameObject);
        }
    }
}

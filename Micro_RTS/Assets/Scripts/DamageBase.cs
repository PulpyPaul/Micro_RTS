using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBase : MonoBehaviour {

    private float baseHealth = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    // On collision, destroy if the tag of the colliding object is unit
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "unit")
        {
            baseHealth -= 5;

            Debug.Log("Base Health: " + baseHealth);

            Destroy(other.gameObject);
        }
    }
}

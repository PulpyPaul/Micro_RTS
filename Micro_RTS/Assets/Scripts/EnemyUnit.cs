using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : MonoBehaviour {

	public float espeed;

	// Use this for initialization
	void Start () {
		espeed = -0.1f; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * espeed;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.tag);

        if(col.gameObject.tag == "base")
        {
            this.gameObject.SetActive(false);
        }
        if (col.gameObject.tag == "unit")
        {
            this.gameObject.SetActive(false);
            col.gameObject.SetActive(false);
        }

    }
}

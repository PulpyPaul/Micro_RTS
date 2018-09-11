using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	public float speed;
    public float cost;

	// Use this for initialization
	void Start () {
		speed = 0.1f; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * speed;
	}
}

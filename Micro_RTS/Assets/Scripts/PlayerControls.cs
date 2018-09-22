using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	public GameObject GameManager;

	SpawnUnit unitSpawner;

	// Use this for initialization
	void Start () {
		unitSpawner = GameManager.GetComponent<SpawnUnit> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			unitSpawner.SpawnMelee (SpawnUnit.Lane.Top);
		}
	}
}

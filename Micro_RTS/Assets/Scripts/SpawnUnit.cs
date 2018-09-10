using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUnit : MonoBehaviour {
    public GameObject unit1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnaUnit()
    {
        GameObject Unit = Instantiate(unit1);
        Unit.transform.position = new Vector3(-3.5f, 0, 0);
    }
}

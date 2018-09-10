using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUnit : MonoBehaviour {
    public GameObject rngUnit;
	public GameObject meleeUnit;

	public Toggle topLane;
	public Toggle midLane;
	public Toggle botLane;

	Vector3 topLoc;
	Vector3 midLoc;
	Vector3 botLoc;

	// Use this for initialization
	void Start () {
		topLoc = new Vector3 (-3.5f, 3, 0);
		midLoc = new Vector3 (-3.5f, 0, 0);
		botLoc = new Vector3 (-3.5f, -3, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnRng()
	{
		if (topLane.isOn) {
			GameObject Unit = Instantiate(rngUnit);
			Unit.transform.position = topLoc;
		}

		if (midLane.isOn) {
			GameObject Unit = Instantiate(rngUnit);
			Unit.transform.position = midLoc;
		}

		if (botLane.isOn) {
			GameObject Unit = Instantiate(rngUnit);
			Unit.transform.position = botLoc;
		}
	}

	public void SpawnMelee()
	{
		if (topLane.isOn) {
			GameObject Unit = Instantiate(meleeUnit);
			Unit.transform.position = topLoc;
		}

		if (midLane.isOn) {
			GameObject Unit = Instantiate(meleeUnit);
			Unit.transform.position = midLoc;
		}

		if (botLane.isOn) {
			GameObject Unit = Instantiate(meleeUnit);
			Unit.transform.position = botLoc;
		}
	}
}

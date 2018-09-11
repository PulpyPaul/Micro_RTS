using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUnit : MonoBehaviour {
    public GameObject rngUnit;
	public GameObject meleeUnit;
    public Resources PlayerResources;
	public Toggle topLane;
	public Toggle midLane;
	public Toggle botLane;

	Vector3 topLoc;
	Vector3 midLoc;
	Vector3 botLoc;

	// Use this for initialization
	void Start () {
        PlayerResources = this.gameObject.GetComponent<Resources>();
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
            if (rngUnit.GetComponent<Unit>().cost < PlayerResources.CurrentRanged)
            {
                PlayerResources.CurrentRanged -= rngUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(rngUnit);
                Unit.transform.position = topLoc;
            }
		}

        if (midLane.isOn)
        {
            if (rngUnit.GetComponent<Unit>().cost < PlayerResources.CurrentRanged)
            {
                PlayerResources.CurrentRanged -= rngUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(rngUnit);
                Unit.transform.position = midLoc;
            }
        }

        if (botLane.isOn)
        {
            if (rngUnit.GetComponent<Unit>().cost < PlayerResources.CurrentRanged)
            {
                PlayerResources.CurrentRanged -= rngUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(rngUnit);
                Unit.transform.position = botLoc;
            }
        }
	}

	public void SpawnMelee()
	{
		if (topLane.isOn) {
            if (meleeUnit.GetComponent<Unit>().cost < PlayerResources.CurrentMelee)
            {
                PlayerResources.CurrentMelee -= meleeUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(meleeUnit);
                Unit.transform.position = topLoc;
            }
		}

		if (midLane.isOn) {
            if (meleeUnit.GetComponent<Unit>().cost < PlayerResources.CurrentMelee)
            {
                PlayerResources.CurrentMelee -= meleeUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(meleeUnit);
                Unit.transform.position = midLoc;
            }
		}

		if (botLane.isOn) {
            if (meleeUnit.GetComponent<Unit>().cost < PlayerResources.CurrentMelee)
            {
                PlayerResources.CurrentMelee -= meleeUnit.GetComponent<Unit>().cost;
                GameObject Unit = Instantiate(meleeUnit);
                Unit.transform.position = botLoc;
            }
		}
	}
}

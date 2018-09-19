using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnUnit : MonoBehaviour {
    public GameObject rngUnit;
	public GameObject meleeUnit;

    public GameObject erngUnit;
    public GameObject emeleeUnit;

    public Resources PlayerResources;
	public Toggle topLane;
	public Toggle midLane;
	public Toggle botLane;

	Vector3 topLoc;
	Vector3 midLoc;
	Vector3 botLoc;



    Random generator = new Random();

    // Use this for initialization
    void Start () {
        PlayerResources = this.gameObject.GetComponent<Resources>();
		topLoc = new Vector3 (-3.5f, 3, 0);
		midLoc = new Vector3 (-3.5f, 0, 0);
		botLoc = new Vector3 (-3.5f, -3, 0);

        InvokeRepeating("spawnEnemy", 3.0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void spawnEnemy()
    {
        float randomF = Random.Range(0.0f, 1.0f);
        float randomF1 = Random.Range(0.0f, 1.0f);
        if (randomF < 0.3)
        {
            if (randomF1 < 0.5)
            {
                GameObject Unit = Instantiate(erngUnit);
                Unit.transform.position = topLoc + new Vector3(8.74f, 0, 0);
            }
            else
            {
                GameObject Unit = Instantiate(emeleeUnit);
                Unit.transform.position = topLoc + new Vector3(8.74f, 0, 0);
            }

        }
        else if (randomF < 0.6)
        {
            if (randomF1 < 0.5)
            {
                GameObject Unit = Instantiate(erngUnit);
                Unit.transform.position = midLoc + new Vector3(8.74f, 0, 0);
            }
            else
            {
                GameObject Unit = Instantiate(emeleeUnit);
                Unit.transform.position = midLoc + new Vector3(8.74f, 0, 0);
            }
        }
        else
        {
            if (randomF1 < 0.5)
            {
                GameObject Unit = Instantiate(erngUnit);
                Unit.transform.position = botLoc + new Vector3(8.74f, 0, 0);
            }
            else
            {
                GameObject Unit = Instantiate(emeleeUnit);
                Unit.transform.position = botLoc + new Vector3(8.74f, 0, 0);
            }
        }
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

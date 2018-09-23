using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

    Vector3 topLoc;
    Vector3 midLoc;
    Vector3 botLoc;

    public GameObject rngUnit;
    public GameObject meleeUnit;

    // Use this for initialization
    void Start () {
        topLoc = new Vector3(-4, 3, 0);
        midLoc = new Vector3(-4f, 0, 0);
        botLoc = new Vector3(-4f, -3, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            CmdSpawnUnit(meleeUnit, topLoc);
        }
	}

    [Command]
    public void CmdSpawnUnit(GameObject prefab, Vector3 position)
    {
        GameObject newUnit = (GameObject)Instantiate(prefab, position, Quaternion.identity);
        NetworkServer.Spawn(newUnit);
    }
}

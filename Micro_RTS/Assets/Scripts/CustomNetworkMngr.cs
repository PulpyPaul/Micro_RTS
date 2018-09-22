using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;

public class CustomNetworkMngr : NetworkManager {
	public GameObject playerSpawnLeft;
	public GameObject playerSpawnRight;

	public GameObject meleeUnit;

	int playerCount = 0;

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		if (playerCount == 0) {
			GameObject player = (GameObject)Instantiate (playerPrefab, playerSpawnRight.transform.position, Quaternion.identity);
			NetworkServer.AddPlayerForConnection (conn, player, playerControllerId);
			playerCount++;
		} else {
			GameObject player = (GameObject)Instantiate (playerPrefab, playerSpawnLeft.transform.position, Quaternion.identity);
			NetworkServer.AddPlayerForConnection (conn, player, playerControllerId);
		}
	}

	public void SpawnUnit(GameObject prefab, Vector3 position) {
		GameObject newUnit = (GameObject)Instantiate (prefab, position, Quaternion.identity);
		NetworkServer.Spawn (newUnit);
	}
}

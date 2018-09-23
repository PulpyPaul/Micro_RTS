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
        if (playerCount >= 2) {
            return;
        }

		if (playerCount == 0) {
			GameObject player = (GameObject)Instantiate (playerPrefab, playerSpawnRight.transform.position, Quaternion.identity);
			NetworkServer.AddPlayerForConnection (conn, player, playerControllerId);
			playerCount++;
		} else {
			GameObject player = (GameObject)Instantiate (playerPrefab, playerSpawnLeft.transform.position, Quaternion.identity);
			NetworkServer.AddPlayerForConnection (conn, player, playerControllerId);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EvisoNetworkManager : NetworkBehaviour {

	public string ip = "192.168.1.192";
	public int port = 25001;

	void OnServerInizialized(){
		Debug.Log ("SERVERR!!");
	}

	void Start(){
		if (isServer) {
			RpcServerToClient ();
//			Debug.LogError ("SONO Server");
		} else {
			CmdClientToServer ();
//			Debug.LogError ("SONO Client");
		}
	}
		

	[ClientRpc]
	void RpcServerToClient(){
		Debug.LogError ("SONO Client");
//		GUI.Label (new Rect (100, 200, 100, 25), "SerToClient");

	}

	[Command]
	void CmdClientToServer(){
		Debug.LogError ("SONO Server");
//		GUI.Label (new Rect (100, 200, 100, 25), "ClientToServer");
	}
}

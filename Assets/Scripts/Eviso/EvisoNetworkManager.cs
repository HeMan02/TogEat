﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EvisoNetworkManager : NetworkBehaviour {

	public string ip = "192.168.1.192";
	public int port = 25001;
	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}

	void OnServerInizialized(){
		Debug.Log ("SERVERR!!");
	}

	void Start(){
		Debug.LogError ("AAAAAAAAAAAA");
		if (isServer) {
			RpcServerToClient ();
//			Debug.LogError ("SONO Server");
		} else {
			CmdClientToServer ();
//			Debug.LogError ("SONO Client");
		}
	}

//	void OnGUI(){
////		Debug.Log("NETWORKKKKKKKKKKKKKKKKKKKKK");
//		if (Network.peerType == NetworkPeerType.Disconnected) {
//			if (GUI.Button (new Rect (100, 100, 100, 25), "Start Client")) {
//				Network.Connect (ip, port);
//			}
//			if (GUI.Button (new Rect (100, 125, 100, 25), "Start Server")) {
//				Network.InitializeServer (10, port);
//			}
//		} else {
//			if (Network.peerType == NetworkPeerType.Client) {
//				GUI.Label (new Rect (100, 100, 100, 25), "CLIENT");
//				if (GUI.Button (new Rect (100, 150, 100, 25), "Logout")) {
//					Network.Disconnect (250);
//				}
//				if (GUI.Button (new Rect (100, 175, 100, 25), "testClient")) {
//					GUI.Label (new Rect (100, 200, 100, 25), "ClientToServer");
//					Debug.LogError ("STAMPA ClientToServer");
////					RpcServerToClient();
//					if (isServer) {
//						Debug.LogError ("SONO Server");
//					} else {
//						Debug.LogError ("SONO Client");
//						CmdClientToServer ();
//					}
//				}
//			}
//			if (Network.peerType == NetworkPeerType.Server) {
//				GUI.Label (new Rect (100, 100, 100, 25), "SERVER");
//				GUI.Label (new Rect (100, 125, 100, 25), "Connection: " + Network.connections.Length );
//				if (GUI.Button (new Rect (100, 150, 100, 25), "Logout")) {
//					Network.Disconnect (250);
//				}
//					if (GUI.Button (new Rect (100, 175, 100, 25), "testServer")) {
//						GUI.Label (new Rect (100, 200, 100, 25), "SerToClient");
//						Debug.LogError ("STAMPA ServerToClient");
////					CmdClientToServer();
//
//						if (isServer) {
//							Debug.LogError ("SONO Server");
//							RpcServerToClient ();
//						} else {
//							Debug.LogError ("SONO Client");
//						}
//					}
//				}
//			
//		}
//	}

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
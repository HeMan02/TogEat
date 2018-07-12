using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class NetworkManagerEviso : NetworkManager {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetKeyDown (KeyCode.S)) {
			StartServer ();
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			StartClient ();
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EvisoNetworkManager : NetworkBehaviour {

	// non sono convinto per ORA di utilizzare una classe statica come instance perchè non ne vedo l'utilizzo
	public string ip = "192.168.1.192";
	public int port = 25001;
	public static EvisoNetworkManager ServerInstance;
	public static EvisoNetworkManager OwnerInstance;

	void OnServerInizialized(){
		Debug.Log ("SERVERR!!");
	}

	// utilizzo l'instance per generare una sola copia del server e per controllare se sono l'owner andrò a vedere se esiste l'instance
	void Awake(){
		if (isServer) {
			ServerInstance = this;
		} else {
			OwnerInstance = this;
		}
	}

	void Start(){
		if (EvisoNetworkManager.ServerInstance != null) {
//			RpcServerToClient (); // nell ostart del server contatta i client , in teoria sarà vuoto un domani
		} else {
//			CmdCheckClient("Pippo","012345",Random.Range (0, 2));
//			CmdClientToServer (); // contatto i lserver
//			CmdPrintNum (Random.Range (0, 2)); // mando un numero al server e lui me l orestituisce uguale
		}
	}

	void Update(){ // Test per vedeer a chi manda i messaggi
		if (Input.GetKeyDown (KeyCode.T) && isServer) {
			RpcServerToClient (); 
		}
	}
		
	// Messaggio dal Server ai clients , problema che ricevono multi messaggi!!
	[ClientRpc]
	void RpcServerToClient(){
		if(isLocalPlayer)
			Debug.LogError ("Server scrive al Client");
	}

	// Messaggio dal Client al server
	[Command]
	void CmdClientToServer(){
		Debug.LogError ("Client scrive al Server");
	}

	[Command]
	void CmdPrintNum(int num){
		Debug.LogError ("client dice al server  il num: " + num);
		TargetResposeToClient (connectionToClient,num);
	}

	[TargetRpc]
	public void TargetResposeToClient(NetworkConnection target,int num){
		Debug.LogError ("sono i lserver e ti rispondo,ho ricevuto il tuo num : " + num);
	}

	[Command]
	public void CmdCheckClient(string name,string password,int num){
		Debug.LogError ("client dice al server  il num: " + num);
		if(num == 0){
			TargetChekValue (connectionToClient,true);
		}else{
			TargetChekValue (connectionToClient,false);
		}
	}

	[TargetRpc]
	public void TargetChekValue(NetworkConnection target,bool checkCLinet){
		Debug.LogError ("sono i lserver e ti rispondo che ho ceccato con : "  + checkCLinet);
	}

}

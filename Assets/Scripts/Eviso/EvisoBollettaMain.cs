using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvisoBollettaMain : MonoBehaviour {

	public GameObject scrollContent;
	// Use this for initialization
	void Start () {
		Debug.Log ("ButtonInstantiate");
		GameObject instance = Instantiate(Resources.Load("Button", typeof(GameObject))) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BackClick ()
	{
		//		EvisoPageManager.instance.mailClient = usernameString;
		//		EvisoPageManager.instance.passClient = passwordString;
		//		EvisoPageManager.instance.CheckPassMailLogInConnection ();
		EvisoPageManager.instance.BackClick("EvisoChoice");
	}
}

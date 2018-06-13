using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvisoBollettaMain : MonoBehaviour {

	public GameObject scrollContent;

	void Start () {
		// istanzio tanti bottoni quante letture ho
		for (int i = 0; i < EvisoPageManager.instance.numberButtonBills; i++){
			Debug.Log ("ButtonInstantiate");
			GameObject instanceObj = Instantiate(Resources.Load("Button", typeof(GameObject))) as GameObject;
			instanceObj.name = "B" + i;
			instanceObj.transform.parent = scrollContent.transform;
		}
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

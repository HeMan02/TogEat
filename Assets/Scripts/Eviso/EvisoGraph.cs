using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvisoGraph : MonoBehaviour {

	public Image fillamountBarF1;
	public Image fillamountBarF2;
	public Image fillamountBarF3;
	// Use this for initialization
	void Start () {
//		Debug.Log (EvisoPageManager.instance.numberButtonBills);
//		Debug.Log (EvisoPageManager.instance.graphList.Count);
		fillamountBarF1.fillAmount = 0;
		fillamountBarF2.fillAmount = 0;
		fillamountBarF3.fillAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		fillamountBarF1.fillAmount = Mathf.Lerp (fillamountBarF1.fillAmount, EvisoPageManager.instance.graphList [EvisoPageManager.instance.numberButtonBills].f1, 1 * Time.deltaTime);
		fillamountBarF2.fillAmount = Mathf.Lerp (fillamountBarF2.fillAmount, EvisoPageManager.instance.graphList [EvisoPageManager.instance.numberButtonBills].f2, 1 * Time.deltaTime);
		fillamountBarF3.fillAmount = Mathf.Lerp (fillamountBarF3.fillAmount, EvisoPageManager.instance.graphList [EvisoPageManager.instance.numberButtonBills].f3, 1 * Time.deltaTime);
	}

	public void BackClick ()
	{
		//		EvisoPageManager.instance.mailClient = usernameString;
		//		EvisoPageManager.instance.passClient = passwordString;
		//		EvisoPageManager.instance.CheckPassMailLogInConnection ();
		EvisoPageManager.instance.BackClick("EvisoBollettaMain");
	}
}

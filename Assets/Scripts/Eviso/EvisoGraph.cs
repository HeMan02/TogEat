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
		fillamountBarF1.fillAmount = 0;
		fillamountBarF2.fillAmount = 0;
		fillamountBarF3.fillAmount = 0;
//		fillamountBarF1.fillAmount = 0.3f;
//		fillamountBarF2.fillAmount = 0.5f;
//		fillamountBarF3.fillAmount = 0.7f;
	}
	
	// Update is called once per frame
	void Update () {
		fillamountBarF1.fillAmount = Mathf.Lerp (fillamountBarF1.fillAmount, 0.3f, 1 * Time.deltaTime);
		fillamountBarF2.fillAmount = Mathf.Lerp (fillamountBarF2.fillAmount, 0.5f, 1 * Time.deltaTime);
		fillamountBarF3.fillAmount = Mathf.Lerp (fillamountBarF3.fillAmount, 0.7f, 1 * Time.deltaTime);
	}

	public void BackClick ()
	{
		//		EvisoPageManager.instance.mailClient = usernameString;
		//		EvisoPageManager.instance.passClient = passwordString;
		//		EvisoPageManager.instance.CheckPassMailLogInConnection ();
		EvisoPageManager.instance.BackClick("EvisoBollettaMain");
	}
}

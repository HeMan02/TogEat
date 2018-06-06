﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EvisoMainPage : MonoBehaviour {

	public static EvisoMainPage instance;
	public GameObject username;
	public GameObject mail;
	public GameObject password;
	public GameObject buttonLogin;
	public GameObject buttonRegister;
	public Text infoText;

	//    TouchScreenKeyboard keyboard;
	string usernameString;
	string passwordString;

	InputField usernameInputField;
	InputField passwordInputField;

	// Use this for initialization
	void Start ()
	{
		instance = this;
		usernameInputField = username.transform.GetChild (0).GetComponent<InputField> ();
		passwordInputField = password.transform.GetChild (0).GetComponent<InputField> ();
		infoText.text = "";
	}

	// Update is called once per frame
	void Update ()
	{
		usernameString = usernameInputField.text;
		passwordString = passwordInputField.text;
		//		Debug.Log ("il testo nome contiene " + usernameString);
		//		Debug.Log ("il testo password contiene " + passwordString);
	}

	public void RegisterClick ()
	{
//		PageManager.instance.RegisterClick();
	}

	public void LoginClick ()
	{
//		EvisoPageManager.instance.mailClient = usernameString;
//		EvisoPageManager.instance.passClient = passwordString;
//		EvisoPageManager.instance.CheckPassMailLogInConnection ();
		EvisoPageManager.instance.EvisoChoiceClick();
	}

	public void OpenLoginPage(){
		Debug.Log("Entrato");
		// Tenuta scena di resgistrazione pèrovvisoria poer vedere se mi cambiava scena come TEST
		PageManager.instance.BackClick ("TogEatRegister");
	}

	public void PrintInfoText(string textToPrint){
		infoText.text = "";
		infoText.text = "" + textToPrint;
	}
}

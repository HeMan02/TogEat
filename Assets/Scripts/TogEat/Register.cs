using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Register : MonoBehaviour
{

    public GameObject username;
    public GameObject mail;
    public GameObject password;
    public GameObject confPassword;
    public GameObject buttonRegisterConfirmed;
    public GameObject buttonFacebook;

    TouchScreenKeyboard keyboard;
    string usernameString;
    string mailString;
    string passwordString;
    string confPAsswordString;

    InputField usernameInputField;
    InputField passwordInputField;
	InputField confPasswordInputField;

    bool emailValid;
    // Use this for initialization
    void Start()
    {
        usernameInputField = username.transform.GetChild(0).GetComponent<InputField>();
        passwordInputField = password.transform.GetChild(0).GetComponent<InputField>();
		confPasswordInputField = confPassword.transform.GetChild(0).GetComponent<InputField>();
    }
	
    // Update is called once per frame
    void Update()
    {
        usernameString = usernameInputField.text;
        passwordString = passwordInputField.text;
		confPAsswordString = confPasswordInputField.text;
        Debug.Log("il testo nome contiene " + usernameString);
        Debug.Log("il testo password contiene " + passwordString);
    }

    public void RegisterClick()
    {
        // salvo i dati
		if(PageManager.instance.CheckLogin (usernameString, passwordString)){
			// open next page 
			Debug.Log("Entrato");
		}else{
			Debug.Log("NON entrato");
			usernameInputField.text = "";
			passwordInputField.text = "";
			confPasswordInputField.text = "";
		}
    }


    public void BackClick()
    {
        PageManager.instance.BackClick("TogEatMain");
    }
}

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
    public GameObject buttonLogin;
    public GameObject buttonRegister;
    public GameObject buttonLoginConfirmed;
    public GameObject buttonRegisterConfirmed;
    public GameObject buttonFacebook;

    TouchScreenKeyboard keyboard;
    string usernameString;
    string mailString;
    string passwordString;
    string confPAsswordString;

    InputField usernameInputField;
    InputField passwordInputField;

    bool emailValid;
    // Use this for initialization
    void Start()
    {
        usernameInputField = username.transform.GetChild(0).GetComponent<InputField>();
        passwordInputField = password.transform.GetChild(0).GetComponent<InputField>();
        BackClick();
    }
	
    // Update is called once per frame
    void Update()
    {
        usernameString = usernameInputField.text;
        passwordString = passwordInputField.text;
        Debug.Log("il testo nome contiene " + usernameString);
        Debug.Log("il testo password contiene " + passwordString);
    }

    public void RegisterClick()
    {
        buttonLoginConfirmed.SetActive(false);
        buttonLogin.SetActive(false);
        buttonRegister.SetActive(false);
        username.SetActive(true);
        password.SetActive(true);
        buttonFacebook.SetActive(true);
        buttonRegisterConfirmed.SetActive(true);
        confPassword.SetActive(true);
    }

    public void LoginClick()
    {
        confPassword.SetActive(false);
        buttonRegisterConfirmed.SetActive(false);
        buttonLogin.SetActive(false);
        buttonRegister.SetActive(false);
        username.SetActive(true);
        password.SetActive(true);
        buttonLoginConfirmed.SetActive(true);
        buttonFacebook.SetActive(true);
    }

    public void BackClick()
    {
        confPassword.SetActive(false);
        buttonRegisterConfirmed.SetActive(false);
        buttonFacebook.SetActive(false);
        buttonLoginConfirmed.SetActive(false);
        username.SetActive(false);
        password.SetActive(false);
        buttonLogin.SetActive(true);
        buttonRegister.SetActive(true);
        usernameInputField.text = "";
        passwordInputField.text = "";
    }

    //    #region ISelectHandler implementation
    //
    //    public void OnSelect(BaseEventData eventData)
    //    {
    //        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    //        keyboard.active = true;
    //    }
    //
    //    #endregion
}

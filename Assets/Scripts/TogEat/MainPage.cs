using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainPage : MonoBehaviour
{

    public GameObject username;
    public GameObject mail;
    public GameObject password;
    public GameObject buttonLogin;
    public GameObject buttonRegister;

    //    TouchScreenKeyboard keyboard;
    string usernameString;
    string passwordString;

    InputField usernameInputField;
    InputField passwordInputField;

    // Use this for initialization
    void Start()
    {
        usernameInputField = username.transform.GetChild(0).GetComponent<InputField>();
        passwordInputField = password.transform.GetChild(0).GetComponent<InputField>();
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
        PageManager.instance.RegisterClick();
    }

    public void LoginClick()
    {
        // salvo i dati
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

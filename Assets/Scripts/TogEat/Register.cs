using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{

    public GameObject usernameInputField;
    public GameObject mail;
    public GameObject passwordInputField;
    public GameObject confPassword;

    string usernameString;
    string mailString;
    string passwordString;
    string confPAsswordString;

    bool emailValid;
    // Use this for initialization
    void Start()
    {
		
    }
	
    // Update is called once per frame
    void Update()
    {
        usernameString = usernameInputField.GetComponent<InputField>().text;
        Debug.Log("il testo nome contiene " + usernameString);
        passwordString = passwordInputField.GetComponent<InputField>().text;
        Debug.Log("il testo password contiene " + passwordString);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{

    public static PageManager instance;
    // Use this for initialization
    void Start()
    {
        instance = this;
//        usernameInputField = username.transform.GetChild(0).GetComponent<InputField>();
//        passwordInputField = password.transform.GetChild(0).GetComponent<InputField>();
//        BackClick();
    }
	
    // Update is called once per frame
    void Update()
    {
//        usernameString = usernameInputField.text;
//        passwordString = passwordInputField.text;
//        Debug.Log("il testo nome contiene " + usernameString);
//        Debug.Log("il testo password contiene " + passwordString);
    }

    public void BackClick(string pageName)
    {
        SceneManager.LoadScene(pageName);
    }

    public void RegisterClick()
    {
        SceneManager.LoadScene("TogEatRegister");
    }
        
}

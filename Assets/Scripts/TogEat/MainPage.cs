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
    public string[] items;

    InputField usernameInputField;
    InputField passwordInputField;

    // Use this for initialization
    void Start()
    {
        usernameInputField = username.transform.GetChild(0).GetComponent<InputField>();
        passwordInputField = password.transform.GetChild(0).GetComponent<InputField>();
    }

    IEnumerator StartConnection()
    {
        WWW itemsData = new WWW("http://192.168.1.237/QueryDB/Query.php"); // LocalHost se sulla stessa macchina
        yield return itemsData;
        string itemsDataString = itemsData.text;
        Debug.Log(itemsDataString);
        items = itemsDataString.Split(';');
        Debug.Log(GetDataValue(items[1], "Name:"));
    }

    IEnumerator InsertData()
    {
        WWW itemsData = new WWW("http://192.168.1.237/QueryDB/Insert.php"); // LocalHost se sulla stessa macchina
        yield return itemsData;
        Debug.Log("Insert");
    }

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
//        value = value.Remove(value.IndexOf("|"));
        return value;
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
//        PageManager.instance.RegisterClick();
        // aggiunta solo per prova
        Debug.Log("start");
        StartCoroutine("StartConnection");
    }

    public void LoginClick()
    {
        // salvo i dati
        StartCoroutine("InsertData");
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

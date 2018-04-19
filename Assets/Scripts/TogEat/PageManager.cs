using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
	// Deve contenere le connessioni al DB e tutte le funzioni possibili da richiamare con COROUTINE
    public static PageManager instance;
	public string[] items;

    void Awake()
    {
        int numGameobject = GameObject.FindGameObjectsWithTag("PageManager").Length;
        if (numGameobject > 1)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start()
    {
        instance = this;
    }
	
    // Update is called once per frame
    void Update()
    {
    }

    public void BackClick(string pageName)
    {
        SceneManager.LoadScene(pageName);
    }

    public void RegisterClick()
    {
        SceneManager.LoadScene("TogEatRegister");
    }

	public bool CheckLogin (string usernameString, string passwordString)
	{
		// query db se nome e pass giusti
		if (false) { // presenti entro
			return true;
		} else
			return false;
	}

	// ================================ CONNESSIONE AL DB ===================================================

	public void OpenConnection(){
		StartCoroutine ("StartConnection");
	}

	public void InsertDataConnection(){
		StartCoroutine ("InsertData");
	}

	public void CiccioDataConnection(){
		StartCoroutine ("CiccioConnect");
	}

	IEnumerator StartConnection ()
	{
		WWW itemsData = new WWW ("http://togeathosting.altervista.org/Query.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;
		Debug.Log (itemsDataString);
//		items = itemsDataString.Split (';');
//		Debug.Log (GetDataValue (items [1], "Name:"));
	}

	IEnumerator InsertData ()
	{
		WWW itemsData = new WWW ("http://localhost/QueryDB/Insert.php");
		yield return itemsData;
		Debug.Log ("Insert");
	}

	IEnumerator CiccioConnect ()
	{
		WWW itemsData = new WWW ("http://togeathosting.altervista.org/Ciccio.php");
		yield return itemsData;
		Debug.Log ("Ciccio http");
	}

	string GetDataValue (string data, string index)
	{
		string value = data.Substring (data.IndexOf (index) + index.Length);
		//        value = value.Remove(value.IndexOf("|"));
		return value;
	}
        
}

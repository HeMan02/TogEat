using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{
	// Deve contenere le connessioni al DB e tutte le funzioni possibili da richiamare con COROUTINE
    public static PageManager instance;
	public string[] items;
	public bool checkToEnter = false;
	public string itemsDataString;
	public string passClient = null;
	public string mailClient = null;
	bool mailCheck = false;
	bool passcheck = false;

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
		items = itemsDataString.Split (';');
		// prendo i dati in modo corretto ma pensare come fare check, una è una coroutine e non è sincronizzata
		Debug.Log("MailClient " + mailClient + " passClient " + passClient );

		for (int i = 0; i < items.Length -1; i++ ){
			mailCheck = false;
			passcheck = false;
			string[] mailAndPass = items[i].Split('|');
			string[] mailTotal = mailAndPass[0].Split (':');
			string mail = null;
			if (mailTotal[1] != null) {
				mail = mailTotal [1];
				if (string.Compare (mailClient, mail) == 0) {
					mailCheck = true;
				}
			}
			string[] passTotal = mailAndPass[1].Split (':');
			string pass = null;
			if (passTotal [1] != null) {
				pass = passTotal [1];
				if (string.Compare (passClient, pass) == 0) {
					passcheck = true;
				}
			}
		}
		if (mailCheck && passcheck) {
			// mi vado a prendere il riferimentop o vedo come dagli l'input per settare a ok e andare avanti se no no
		}
	}

//	IEnumerator InsertData ()
//	{
////		WWW itemsData = new WWW ("http://togeathosting.altervista.org/Insert.php");
////		yield return itemsData;
//	}

	IEnumerator CiccioConnect ()
	{
		WWW itemsData = new WWW ("http://togeathosting.altervista.org/Ciccio.php");
		yield return itemsData;
	}

	string GetDataValue (string data, string index)
	{
		string value = data.Substring (data.IndexOf (index) + index.Length);
		//        value = value.Remove(value.IndexOf("|"));
		return value;
	}
        
}

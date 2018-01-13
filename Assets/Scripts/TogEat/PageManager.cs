using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PageManager : MonoBehaviour
{

    public static PageManager instance;

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
        
}

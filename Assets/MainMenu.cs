using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    private bool isActive = false;
    private GameObject menu;

	// Use this for initialization
	void Start () {
        menu = GameObject.Find("MainMenuCanvas");
        menu.SetActive(isActive);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape"))
        {
            isActive = !isActive;
            menu.SetActive(isActive);
        }
	}
}

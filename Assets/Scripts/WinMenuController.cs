﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ReturnToMenu() {
		UnityEngine.SceneManagement.SceneManager.LoadScene (0);
	}
}

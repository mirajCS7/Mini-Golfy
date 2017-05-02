﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log ("Level load requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void quitLevel() {
		Debug.Log ("Quit function requested");
		Application.Quit();
	}
	
}

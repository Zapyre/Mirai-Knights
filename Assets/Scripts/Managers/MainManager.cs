﻿using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		GUIManager.InitGUI ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		GUIManager.DrawGUI ();
	}
}
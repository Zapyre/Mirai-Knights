using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
		GameManager.InitWorld ();
		GUIManager.InitGUI ();
		SquadManager.InitSquadManager ();
	}
	
	// Update is called once per frame
	void Update () {
		GameManager.Update ();
	}

	void OnGUI () {
		GUIManager.DrawGUI ();
	}
}

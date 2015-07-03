using UnityEngine;
using System.Collections;

public static class CreateCharacterGui {
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;
	public static string squadName;
	public static string charName;

	public static void InitGUI () {
		MainMenuButton mmb = new MainMenuButton ();
		CreateCharacterButton ccb = new CreateCharacterButton ();

		squadName = "Mystic Divers";
		charName = "John";
		
		buttonList = new ArrayList ();
		buttonList.Add (mmb);
		buttonList.Add (ccb);
				
		RefreshTimer ();
	}

	public static void RefreshTimer (){
		selection = 0;
		timeInc = 0.25f;
		currentTime = Time.time;
		timerCount = currentTime + timeInc;
	}
	
	public static void DrawGUI (){
		currentTime = Time.time;
		if (Input.GetKey ("space") && currentTime > timerCount) {
			timerCount = currentTime + timeInc;
			((Button)buttonList[selection]).Action ();
		}
		if ((Input.GetKey ("left") || Input.GetKey ("up")) && currentTime > timerCount) {
			selection--;
			if (selection < 0){
				selection = buttonList.Count - 1;
			}
			timerCount = currentTime + timeInc;
		}
		if ((Input.GetKey ("right") || Input.GetKey ("down")) && currentTime > timerCount) {
			selection++;
			if (selection >= buttonList.Count) {
				selection = 0;
			}
			timerCount = currentTime + timeInc;
		}

		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUI.Label (new Rect (GUIManager.gridWidth * 4, (GUIManager.gridHeight + GUIManager.padding) * 0, GUIManager.gridWidth, GUIManager.gridHeight), "Character Creation");
		GUI.Label (new Rect (GUIManager.gridWidth * 3, (GUIManager.gridHeight + GUIManager.padding) * 1, GUIManager.gridWidth, GUIManager.gridHeight), "Squad Name");
		squadName = GUI.TextField (new Rect (GUIManager.gridWidth * 4, (GUIManager.gridHeight + GUIManager.padding) * 1, GUIManager.gridWidth * 2, GUIManager.gridHeight), squadName, 25);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, (GUIManager.gridHeight + GUIManager.padding) * 2, GUIManager.gridWidth, GUIManager.gridHeight), "Character Name");
		charName = GUI.TextField (new Rect (GUIManager.gridWidth * 4, (GUIManager.gridHeight + GUIManager.padding) * 2, GUIManager.gridWidth * 2, GUIManager.gridHeight), charName, 25);

		for (int i = 0; i < buttonList.Count; i++) {
			if (i == selection){
				GUI.color = Color.yellow;
			}
			else {
				GUI.color = Color.white;
			}
			if (GUI.Button (new Rect ((GUIManager.gridWidth + GUIManager.padding) * (3 + i * 2), (GUIManager.gridHeight + GUIManager.padding) * 6, GUIManager.gridWidth, GUIManager.gridHeight), ((Button)buttonList[i]).GetName())) {
				((Button)buttonList[i]).Action ();
			}
		}
	}
}
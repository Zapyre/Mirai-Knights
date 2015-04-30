using UnityEngine;
using System.Collections;

public static class CreateCharacterGui {
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;

	public static void InitGUI () {
		MainMenuButton mmb = new MainMenuButton ();
		CreateCharacterButton ccb = new CreateCharacterButton ();
		
		buttonList = new ArrayList ();
		buttonList.Add (mmb);
		buttonList.Add (ccb);
				
		selection = 0;
		timeInc = 0.25f;
		currentTime = Time.time;
		timerCount = currentTime + timeInc;

	}
	
	public static void DrawGUI (){
		currentTime = Time.time;
		if (Input.GetKey ("space") && currentTime > timerCount) {
			((Button)buttonList[selection]).Action ();
			timerCount = currentTime + timeInc;
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
		GUI.TextField (new Rect (GUIManager.gridWidth * 4, (GUIManager.gridHeight + GUIManager.padding) * 1, GUIManager.gridWidth * 2, GUIManager.gridHeight), "Squad Name", 25);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, (GUIManager.gridHeight + GUIManager.padding) * 2, GUIManager.gridWidth, GUIManager.gridHeight), "Character Name");
		GUI.TextField (new Rect (GUIManager.gridWidth * 4, (GUIManager.gridHeight + GUIManager.padding) * 2, GUIManager.gridWidth * 2, GUIManager.gridHeight), "Character Name", 25);

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
using UnityEngine;
using System.Collections;

public static class MainMenuGui {
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;
	
	public static void InitGUI () {
		ContinueButton cb = new ContinueButton ();
		NewGameButton nb = new NewGameButton ();
		OptionButton ob = new OptionButton ();
		
		buttonList = new ArrayList ();
		buttonList.Add (cb);
		buttonList.Add (nb);
		buttonList.Add (ob);
		
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
		for (int i = 0; i < buttonList.Count; i++) {
			if (i == selection){
				GUI.color = Color.yellow;
			}
			else {
				GUI.color = Color.white;
			}
				if (GUI.Button (new Rect ((GUIManager.gridWidth + GUIManager.padding) * (3 + i), (GUIManager.gridHeight + GUIManager.padding) * 2, GUIManager.gridWidth, GUIManager.gridHeight), ((Button)buttonList[i]).GetName())) {
				((Button)buttonList[i]).Action ();
			}
		}
	}
}
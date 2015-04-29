using UnityEngine;
using System.Collections;

public static class GUIManager {
	public static int gridWidth;
	public static int gridHeight;
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;

	public static void InitGUI () {
		gridWidth = Screen.width / 9;
		gridHeight = Screen.height / 5;

		ContinueButton cb = new ContinueButton ();
		NewGameButton nb = new NewGameButton ();
		OptionButton ob = new OptionButton ();

		buttonList = new ArrayList ();
		buttonList.Add (cb);
		buttonList.Add (nb);
		buttonList.Add (ob);

		selection = 0;
		currentTime = Time.time;
		timerCount = currentTime;
		timeInc = 0.25f;
	}

	public static void DrawGUI (){
		currentTime = Time.time;
		if (Input.GetKey ("space") && currentTime > timerCount) {
			((Button)buttonList[selection]).Action ();
			timerCount = currentTime + timeInc;
		}
		if (Input.GetKey ("left") && currentTime > timerCount) {
			selection--;
			if (selection < 0){
				selection = buttonList.Count - 1;
			}
			timerCount = currentTime + timeInc;
		}
		if (Input.GetKey ("right") && currentTime > timerCount) {
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
			if (GUI.Button (new Rect (Screen.width / 9 * (3 + i), Screen.height / 5 * 2, gridWidth, gridHeight), ((Button)buttonList[i]).GetName())) {
				((Button)buttonList[i]).Action ();
			}
		}
	}
}

using UnityEngine;
using System.Collections;

public static class GUIManager {
	public static float gridWidth;
	public static float gridHeight;
	public static float padding;
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;

	public enum Mode {Main, Create, Option};
	public static Mode curMode;

	public static void InitGUI () {
		padding = 10f;
		gridWidth = (Screen.width - padding * 8) / 9;
		gridHeight = (Screen.height - padding * 4) / 9;
		curMode = Mode.Main;

		MainMenuGui.InitGUI ();
		//CreateCharacterGui.InitGUI ();
	}

	public static void DrawGUI (){
		if (curMode == Mode.Main){
			MainMenuGui.DrawGUI();
		}
		if (curMode == Mode.Create) {
			CreateCharacterGui.DrawGUI();
		}
	}
}

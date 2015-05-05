using UnityEngine;
using System.Collections;

public static class WorldMapGui {
	private static ArrayList buttonList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;

	private static Map curMap;
	private static int buttonSize;

	public static void InitGUI () {
		curMap = MapManager.curMap;
		ArrayList landmarkList = curMap.GetLandmarkList ();


		buttonList = new ArrayList ();
		foreach (Landmark lm in landmarkList){
			LandmarkButton cb = new LandmarkButton (lm.GetName(), lm.GetPosition().x, lm.GetPosition().y);
			buttonList.Add (cb);
		}
		
		RefreshTimer ();

		buttonSize = 100;
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
			else if (SquadManager.curSquad.GetCurLoc().GetName() == ((Button)buttonList[i]).GetName()){
				GUI.color = Color.green;
			}
			else {
				GUI.color = Color.white;
			}
			if (GUI.Button (new Rect ((((Button)buttonList[i]).GetPosition().x + 5) * buttonSize, (((Button)buttonList[i]).GetPosition().y + 5) * buttonSize, buttonSize, buttonSize), ((Button)buttonList[i]).GetName())) {
				((Button)buttonList[i]).Action ();
			}
		}
	}
}
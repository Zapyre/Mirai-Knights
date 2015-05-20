using UnityEngine;
using System.Collections;

public static class WorldMapGui {
	private static ArrayList buttonList;
	private static ArrayList conList;
	private static int selection;
	private static float currentTime;
	private static float timerCount;
	private static float timeInc;

	private static Map curMap;
	private static int buttonSize;

	private static Texture2D point;
	 
	public static Landmark curLandmark;


	public static void InitGUI () {
		// Init point texture
		point = new Texture2D(3, 3, TextureFormat.ARGB32, false);
		// set the pixel values
		point.SetPixel(0, 0, Color.black);
		point.SetPixel(1, 0, Color.black);
		point.SetPixel(2, 0, Color.black);
		point.SetPixel(0, 1, Color.black);
		point.SetPixel(1, 1, Color.black);
		point.SetPixel(2, 1, Color.black);
		point.SetPixel(0, 2, Color.black);
		point.SetPixel(1, 2, Color.black);
		point.SetPixel(2, 2, Color.black);
		// Apply all SetPixel calls
		point.Apply();

		curMap = MapManager.curMap;
		ArrayList landmarkList = curMap.GetLandmarkList ();
		conList = curMap.GetConnectionList ();


		buttonList = new ArrayList ();
		foreach (Landmark lm in landmarkList){
			LandmarkButton cb = new LandmarkButton (lm);
			buttonList.Add (cb);
		}
		
		RefreshTimer ();

		buttonSize = 110;

		curLandmark = null;
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

		// Connections generation
		for (int i = 0; i < conList.Count; i++) {
			GUI.color = Color.white;
			ArrayList landmarkList = ((Connection)conList[i]).GetLandmarkList();
			Vector2 midpoint = new Vector2 (0,0);
			for (int j = 0; j < landmarkList.Count; j++){
				midpoint += (((Landmark)landmarkList[j]).GetPosition () + new Vector2(3,4)) * buttonSize + new Vector2(buttonSize/2,buttonSize/2);
			}
			midpoint /= landmarkList.Count;

			for (int j = 0; j < landmarkList.Count; j++){
				DrawLine ((((Landmark)landmarkList[j]).GetPosition() + new Vector2(3,4)) * buttonSize + new Vector2(buttonSize/2,buttonSize/2), midpoint, 10);
			}
		}

		// Map generation (Buttons)
		for (int i = 0; i < buttonList.Count; i++) {
			if (i == selection){
				GUI.color = Color.yellow;
			}
			else if (SquadManager.curSquad.GetCurLoc().GetName() == ((Button)buttonList[i]).GetName()){
				GUI.color = Color.green;
			}
			else if (((LandmarkButton)buttonList[i]).IsHostile()){
				GUI.color = Color.red;
			}
			else {
				GUI.color = Color.white;
			}
			if (GUI.Button (new Rect ((((Button)buttonList[i]).GetPosition().x + 3) * buttonSize, (((Button)buttonList[i]).GetPosition().y + 4) * buttonSize, buttonSize, buttonSize), ((Button)buttonList[i]).GetName())) {
				((Button)buttonList[i]).Action ();
				selection = i;
			}
		}

		// Side Menu generation (Buttons)
		if (curLandmark != null){
			GUI.color = Color.white;
			if (GUI.Button (new Rect (Screen.width - buttonSize * 2, Screen.height - buttonSize, buttonSize * 2, buttonSize), "Go to " + curLandmark.GetName())) {
				SquadManager.curSquad.SetCurLoc(curLandmark);
				curLandmark = null;
			}
		}
		else {
			GUI.color = Color.white;
			Landmark lm = SquadManager.curSquad.GetCurLoc();
			ArrayList lmMenuOptionList = lm.GetMenu().GetOptions();
			for (int i = 0; i < lmMenuOptionList.Count; i++){
				if (GUI.Button (new Rect (Screen.width - buttonSize * 2, Screen.height - buttonSize * (i + 1), buttonSize * 2, buttonSize), (string)lmMenuOptionList[i])) {
					Debug.Log(lmMenuOptionList[i] + " Clicked");
				}
			}
		}
	}

	private static void DrawLine(Vector2 start, Vector2 end, int width)
	{
		Vector2 d = end - start;
		float a = Mathf.Rad2Deg * Mathf.Atan(d.y / d.x);
		if (d.x < 0)
			a += 180;
		
		int width2 = (int) Mathf.Ceil(width / 2);
		
		GUIUtility.RotateAroundPivot(a, start);
		GUI.DrawTexture(new Rect(start.x, start.y - width2, d.magnitude, width), point);
		GUIUtility.RotateAroundPivot(-a, start);
	}
}
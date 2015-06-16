using UnityEngine;
using System.Collections;

public class HostileMenu : Menu{
	public HostileMenu (){
		optionList = new ArrayList ();
		optionList.Add ("Sneak by the area");
		optionList.Add ("Risk entering the area");
		optionList.Add ("Liberate the area");
	}

	public override void Action (string option){
		if (option == "Liberate the area") {
			int i = -1;
			int j = 0;
			foreach (Landmark lm in DataManager.curMap.GetLandmarkList()){
				if (lm.GetName () == DataManager.curSquad.GetCurLoc().GetName ()){
					i = j;
				}
				j++;
			}
			if (i != -1){
				((Landmark)(DataManager.curMap.GetLandmarkList()[i])).SetHostile(false);
				((Landmark)(DataManager.curMap.GetLandmarkList()[i])).AutoMenu();
				WorldMapGui.UpdateButtonList();
			}
		}
		else {
			Debug.Log(option + " Clicked");
		}
	}
}

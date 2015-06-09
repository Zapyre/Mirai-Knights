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
			foreach (Landmark lm in GameManager.curMap.GetLandmarkList()){
				if (lm.GetName () == SquadManager.curSquad.GetCurLoc().GetName ()){
					i = j;
				}
				j++;
			}
			if (i != -1){
				((Landmark)(GameManager.curMap.GetLandmarkList()[i])).SetHostile(false);
				WorldMapGui.UpdateButtonList();
			}
		}
		else {
			Debug.Log(option + " Clicked");
		}
	}
}

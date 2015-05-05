using UnityEngine;
using System.Collections;

public class TownMenu : Menu{
	public TownMenu (){
		optionList = new ArrayList ();
		optionList.Add ("Look for the pub");
		optionList.Add ("Visit the local blacksmith");
		optionList.Add ("Leave town");
	}
}

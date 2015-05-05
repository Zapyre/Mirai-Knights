using UnityEngine;
using System.Collections;

public class CastleMenu : Menu{
	public CastleMenu (){
		optionList = new ArrayList ();
		optionList.Add ("Visit the local blacksmith");
		optionList.Add ("Inquire at the recruitment office");
		optionList.Add ("Look at the missions board");
		optionList.Add ("Leave the Castle");
	}
}
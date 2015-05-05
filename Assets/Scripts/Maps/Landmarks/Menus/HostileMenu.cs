using UnityEngine;
using System.Collections;

public class HostileMenu : Menu{
	public HostileMenu (){
		optionList = new ArrayList ();
		optionList.Add ("Sneak by the area");
		optionList.Add ("Risk entering the area");
		optionList.Add ("Liberate the area");
	}
}

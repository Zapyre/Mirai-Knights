using UnityEngine;
using System.Collections;

public abstract class HostileMenu : Menu{
	public HostileMenu (){
		optionList.Add ("Sneak by the area");
		optionList.Add ("Risk entering the area");
		optionList.Add ("Liberate the area");
	}
}
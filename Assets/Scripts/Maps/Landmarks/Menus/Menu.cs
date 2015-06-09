using UnityEngine;
using System.Collections;

public abstract class Menu {
	protected string name;
	protected ArrayList optionList;

	public string GetName () { return name; }
	public ArrayList GetOptions () { return optionList; }
	public virtual void Action (string option) {
		Debug.Log(option + " Clicked");
	}
}

using UnityEngine;
using System.Collections;

public class Squad {
	protected ArrayList unitList;
	protected string name;
	protected int experience;
	protected int funds;

	// Getters
	public ArrayList GetUnitList (){ return unitList; }
	public string GetName (){ return name; }
	public void SetName (string n){ name = n; }
	public int GetExperience (){ return experience; }
}

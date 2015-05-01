using UnityEngine;
using System.Collections;

public class Squad {
	protected ArrayList unitList;
	protected string name;
	protected int experience;
	protected int funds;
	protected ArrayList squadItemList;

	// Getters
	public ArrayList GetUnitList (){ return unitList; }
	public void AddUnit (Unit u){ unitList.Add (u); }
	public string GetName (){ return name; }
	public void SetName (string n){ name = n; }
	public int GetExperience (){ return experience; }
	public void SetExperience (int e){ experience = e; }
	public int GetFunds (){ return funds; }
	public void SetFunds (int f){ funds = f; }
	public ArrayList GetSquadItemList (){ return squadItemList; }
	public void SetSquadItemList (ArrayList i) { squadItemList = i; }

}

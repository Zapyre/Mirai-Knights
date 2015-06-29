using UnityEngine;
using System.Collections;

public class Squad {
	protected Unit leader;
	protected ArrayList unitList;
	protected string name;
	protected int experience;
	protected int funds;
	protected ArrayList squadItemList;
	protected Landmark curLoc;

	public Squad (){
		unitList = new ArrayList ();
		squadItemList = new ArrayList ();
	}

	public Squad (string n){
		unitList = new ArrayList ();
		squadItemList = new ArrayList ();
		name = n;
	}

	// Getters
	public Unit GetLeader (){ return leader; }
	public void SetLeader (Unit l){ leader = l; }
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
	public Landmark GetCurLoc () { return curLoc; }
	public void SetCurLoc (Landmark cl) { curLoc = cl; }

	// Temp statistics
	public int GetSquadStr (){
		int str = 0;
		foreach (Unit u in unitList) {
			str += u.GetStrength();
		}
		return str;
	}
}

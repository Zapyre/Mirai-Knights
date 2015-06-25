using UnityEngine;
using System;
using System.Collections;

public abstract class Landmark:IComparable {
	protected Texture landmarkPortrait;
	protected string name;
	protected Vector2 position;
	protected ArrayList pathList;
	protected Menu menu;
	protected bool hostile;
	protected int hostileRating;
	protected Squad hostileSquad;
	protected Vector2 difficulty;
	protected bool shown;

	// AutoMenu 
	public virtual void AutoMenu (){
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new CastleMenu ();
		}
	}

	// Getters and Setters
	public Texture GetLandmarkPortrait () { return landmarkPortrait; }
	public void SetLandmarkPortrait (Texture lp) { landmarkPortrait = lp; }
	public string GetName() { return name; }
	public void SetName(string n) { name = n; }
	public Vector2 GetPosition () { return position; }
	public void SetPostion (Vector2 p) { position = p; }
	public ArrayList GetPathList () { return pathList; }
	public void SetPathList (ArrayList pl) { pathList = pl; }
	public Menu GetMenu () { return menu; }
	public void SetMenu (Menu m) { menu = m; }
	public bool IsHostile () { return hostile; }
	public void SetHostile (bool h) { hostile = h; }
	public int GetHostileRating () { return hostileRating; }
	public void SetHostileRating (int hr) { hostileRating = hr; }
	public Squad GetHostileSquad () { return hostileSquad; }
	public void SetHostileSquad (Squad s) { hostileSquad = s; }
	public Vector2 GetDifficulty () { return difficulty; }
	public bool IsShown () { return shown; }
	public void SetShown (bool s) { shown = s; }

	public int CompareTo(object obj){
		if (obj is Landmark) {
			Landmark compLm = (Landmark) obj;
			if (name.Equals(compLm.GetName())){
				return 0;
			}
			else {
				return name.CompareTo(compLm.GetName());
			}
		}
		return 1;
	}
}
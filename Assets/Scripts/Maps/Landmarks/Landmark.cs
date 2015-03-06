using UnityEngine;
using System.Collections;

public abstract class Landmark {
	protected Texture landmarkPortrait;
	protected string name;
	protected Vector2 position;
	protected ArrayList landmarkConnectionList;
	protected Menu menu;
	protected bool hostile;

	// Getters and Setters
	public Texture GetLandmarkPortrait () { return landmarkPortrait; }
	public void SetLandmarkPortrait (Texture lp) { landmarkPortrait = lp; }
	public string GetName() { return name; }
	public void SetName(string n) { name = n; }
	public Vector2 GetPosition () { return position; }
	public void SetPostion (Vector2 p) { position = p; }
	public ArrayList GetLandmarkConnectionList () { return landmarkConnectionList; }
	public void SetLandmarkConnectionList (ArrayList lcl) { landmarkConnectionList = lcl; }
	public Menu GetMenu () { return menu; }
	public void SetMenu (Menu m) { menu = m; }
	public bool isHostile () { return hostile; }
	public void setHostile (bool h) { hostile = h; }
}
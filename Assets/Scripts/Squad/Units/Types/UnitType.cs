using UnityEngine;
using System.Collections;
using System;

public abstract class UnitType : UnitStatistics{
	// General
	protected string name;
	protected int level;
	protected int experience;

	public string GetName(){
		return name;
	}
	public int GetLevel (){
		return level;
	}
	public int GetExperience(){
		return experience;
	}
	public void AddExperience(int exp){
		experience += exp;
	}
}

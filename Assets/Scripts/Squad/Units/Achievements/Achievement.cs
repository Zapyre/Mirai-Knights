using UnityEngine;
using System.Collections;

public abstract class Achievement : UnitStatistics{
	// General
	protected string name;
	protected string description;
	protected bool unlockCondition (){ return false; }
}

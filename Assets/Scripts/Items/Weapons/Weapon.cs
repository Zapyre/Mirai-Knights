using UnityEngine;
using System.Collections;
public abstract class Weapon : Item {
	public enum WeaponType { Melee, Ranged, Shield };
	public enum WeaponSlot { OneHanded, TwoHanded };
	protected int weaponType;
	protected int weaponSlot;

	// Getters
	public int GetWeaponType () { return weaponType; }
	public int GetWeaponSlot () { return weaponSlot; }
	public int GetItemType () { return (int) Item.ItemType.Weapon; }
}
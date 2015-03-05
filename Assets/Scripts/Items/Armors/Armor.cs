using UnityEngine;
using System.Collections;
public abstract class Armor : Item {
	public enum ArmorSlot { Head, Chest, Hands, Legs, Feet };
	protected int armorSlot;
	
	// Getters
	public int GetArmorSlot () { return armorSlot; }
	public int GetItemType () { return (int) Item.ItemType.Armor; }
}
using UnityEngine;
using System.Collections;

public class Novice : UnitType{
	public Novice (Unit u){
		// General
		name = "Novice";

		// Str Related Attributes
		physicalAttack = 7 + u.GetStrength ();
		physicalRange = 0 + (int)(u.GetStrength () / 5);
		block[(int)Attack.Direction.Front] = 25 + u.GetStrength (); // Only occurs with shield equiped
		block[(int)Attack.Direction.Side] = 10 + u.GetStrength ();
		block[(int)Attack.Direction.Back] = u.GetStrength ();
		
		// Dex Related Attributes
		speed = 3 + (int)(u.GetDexterity () / 5);
		dodge[(int)Attack.Direction.Front] = 50 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Side] = 10 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Back] = u.GetDexterity ();
		phyisicalAim = 90 + u.GetDexterity ();
		
		// Int Related Attributes
		magicAttack = 7 + u.GetIntelligence ();
		magicAim = 90 + u.GetIntelligence ();
		magicRange = 0 + (int)(u.GetIntelligence () / 5);
		
		// End Related Attributes
		health = 80 + 10 * u.GetEndurance ();
		shield = 0;
		
		// Mixed Attributes
		actionPoints = 3 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5) + (int)(u.GetIntelligence () / 5) + (int)(u.GetEndurance () / 5);
		jump = 3 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5);
		physicalArmor = 5 + u.GetStrength () + u.GetEndurance ();
		magicArmor = 5 + u.GetIntelligence () + u.GetEndurance ();
	}
}
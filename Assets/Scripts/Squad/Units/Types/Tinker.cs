using UnityEngine;
using System.Collections;

public class Tinker : UnitType{
	public Tinker (Unit u){
		// General
		name = "Tinker";

		// Str Related Attributes
		physicalAttack = 8 + u.GetStrength ();
		physicalRange = 1 + (int)(u.GetStrength () / 5);
		block[(int)Attack.Direction.Front] = 30 + u.GetStrength (); // Only occurs with shield equiped
		block[(int)Attack.Direction.Side] = 10 + u.GetStrength ();
		block[(int)Attack.Direction.Back] = u.GetStrength ();
		
		// Dex Related Attributes
		speed = 3 + (int)(u.GetDexterity () / 5);
		dodge[(int)Attack.Direction.Front] = 50 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Side] = 10 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Back] = u.GetDexterity ();
		physicalAim = 95 + u.GetDexterity ();
		
		// Int Related Attributes
		magicAttack = 8 + u.GetIntelligence ();
		magicAim = 95 + u.GetIntelligence ();
		magicRange = 0 + (int)(u.GetIntelligence () / 5);
		
		// End Related Attributes
		health = 90 + 10 * u.GetEndurance ();
		shield = 0;
		
		// Mixed Attributes
		actionPoints = 4 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5) + (int)(u.GetIntelligence () / 5) + (int)(u.GetEndurance () / 5);
		jump = 3 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5);
		physicalArmor = 8 + u.GetStrength () + u.GetEndurance ();
		magicArmor = 8 + u.GetIntelligence () + u.GetEndurance ();
	}
}


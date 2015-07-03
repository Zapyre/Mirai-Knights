using UnityEngine;
using System.Collections;

public class Soldier : UnitType{
	public Soldier (Unit u) {
		// General
		name = "Soldier";

		// Str Related Attributes
		physicalAttack = 10 + u.GetStrength ();
		physicalRange = 0 + (int)(u.GetStrength () / 5);
		block[(int)Attack.Direction.Front] = 50 + u.GetStrength (); // Only occurs with shield equiped
		block[(int)Attack.Direction.Side] = 10 + u.GetStrength ();
		block[(int)Attack.Direction.Back] = u.GetStrength ();

		// Dex Related Attributes
		speed = 2 + (int)(u.GetDexterity () / 5);
		dodge[(int)Attack.Direction.Front] = 50 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Side] = 10 + u.GetDexterity ();
		dodge[(int)Attack.Direction.Back] = u.GetDexterity ();
		physicalAim = 100 + u.GetDexterity ();

		// Int Related Attributes
		magicAttack = 5 + u.GetIntelligence ();
		magicAim = 50 + u.GetIntelligence ();
		magicRange = 0 + (int)(u.GetIntelligence () / 5);

		// End Related Attributes
		health = 100 + 10 * u.GetEndurance ();
		shield = 0;

		// Mixed Attributes
		actionPoints = 3 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5) + (int)(u.GetIntelligence () / 5) + (int)(u.GetEndurance () / 5);
		jump = 2 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5);
		physicalArmor = 10 + u.GetStrength () + u.GetEndurance ();
		magicArmor = 5 + u.GetIntelligence () + u.GetEndurance ();
	}
}

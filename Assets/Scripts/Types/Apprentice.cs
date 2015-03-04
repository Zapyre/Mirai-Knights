using UnityEngine;
using System.Collections;

public class Apprentice : Type{
	public Apprentice (Unit u){
		// General
		name = "Apprentice";

		// Str Related Attributes
		physicalAttack = 5 + u.GetStrength ();
		physicalRange = 0 + (int)(u.GetStrength () / 5);
		frontBlock = 10 + u.GetStrength (); // Only occurs with shield equiped
		sideBlock = 10 + u.GetStrength ();
		backBlock = u.GetStrength ();
		
		// Dex Related Attributes
		speed = 2 + (int)(u.GetDexterity () / 5);
		frontDodge = 25 + u.GetDexterity ();
		sideDodge = 10 + u.GetDexterity ();
		backDodge = u.GetDexterity ();
		phyisicalAim = 80 + u.GetDexterity ();
		
		// Int Related Attributes
		magicAttack = 10 + u.GetIntelligence ();
		magicAim = 100 + u.GetIntelligence ();
		magicRange = 1 + (int)(u.GetIntelligence () / 5);
		
		// End Related Attributes
		health = 80 + 10 * u.GetEndurance ();
		shield = 0;
		
		// Mixed Attributes
		actionPoints = 3 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5) + (int)(u.GetIntelligence () / 5) + (int)(u.GetEndurance () / 5);
		jump = 2 + (int)(u.GetStrength () / 5) + (int)(u.GetDexterity () / 5);
		physicalArmor = 5 + u.GetStrength () + u.GetEndurance ();
		magicArmor = 10 + u.GetIntelligence () + u.GetEndurance ();
	}
}
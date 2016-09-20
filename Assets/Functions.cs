using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	public int weapon = 0;
	private string weaponName = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp("space")) 
		{
				WeaponSearch(); //This is a function call
		}
	}

	void WeaponSearch()//This is a function definition
	{
		weapon = Random.Range (1, 5);

		switch (weapon) {
		case 1:
			weaponName = "sword";
			DisplayMessage (weaponName);
			break;
		case 2:
			weaponName = "axe";
			DisplayMessage (weaponName);
			break;
		case 3:
			weaponName = "dagger";
			DisplayMessage (weaponName);
			break;
		case 4:
			weaponName = "bow";
			DisplayMessage (weaponName);
			break;
		default:
			Debug.Log ("You need to find a weapon!");
			break;
		}

		void DisplayMessage(string weaponName)
		{
			Debug.Log("You found the " + weaponName + "!");
		}
	}




		


}

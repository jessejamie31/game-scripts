using UnityEngine;
using System.Collections;

public class loop : MonoBehaviour {

	int numbadguys = 5;

	// Use this for initialization
	void Start () {
	
		for (int i = 0; i < numbadguys; i++) {
			Debug.Log ("Creating badguy number: " + i);
		}
	}
}

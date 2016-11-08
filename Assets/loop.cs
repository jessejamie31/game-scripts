using UnityEngine;
using System.Collections;

public class loop : MonoBehaviour {

	int numCandybars = 5;

	// Use this for initialization
	void Start () {
	
		for (int i = 0; i < numCandybars; i++) {
			Debug.Log ("Creating candbar number: " + i);
		}
	}
}

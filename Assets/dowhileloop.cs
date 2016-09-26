using UnityEngine;
using System.Collections;

public class dowhileloop : MonoBehaviour {

	int badguys = 3;

	// Use this for initialization
	void Start () 
	{
		while(badguys > 0);
		{
			Debug.Log ("Enemy Terminated");
			badguys--;
		}
	
	
	}
}

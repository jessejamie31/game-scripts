using UnityEngine;
using System.Collections;

public class scopeaccess : MonoBehaviour {

	public int badguy = 1;
	private int goodguy = 2;

	private AnotherClass myOtherClass;

	// Use this for initialization
	void Start () {

		badguy = 3;

		myOtherClass = new AnotherClass ();
		myOtherClass.DCheroes(badguy, myOtherClass.batman);
	
	}

	void Example(int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * badguy;
		Debug.Log (answer);
	}
	// Update is called once per frame
	void Update () {
			Debug.Log ("badguy is set to: "+badguy);
	
	}
}

using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour {

	public int batman;
	public int superman;

	private int joker;

	public void DCheroes (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Hero total: " + answer);
	}

}

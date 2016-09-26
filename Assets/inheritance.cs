using UnityEngine;
using System.Collections;

public class inheritance : MonoBehaviour {

	public class Candybar
	{
		public string color;

	// Use this for initialization
		public Candybar() 
		{
			color = "red";
			Debug.Log("1st Candybar Constructor Called");
	}
		public Candybar(string newColor)
		{
			color = newColor;
			Debug.Log("2nd Candybar Constructor Called");
	
		}

		public void Eat()
	{
		Debug.Log ("The " + color + " candybar has been eaten.");
	}
		public void SayHello()
		{
			Debug.Log ("Hello, I am a candybar.");
		}
}
}

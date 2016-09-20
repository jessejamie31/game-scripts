using UnityEngine;
using System.Collections;

public class Ifstatements : MonoBehaviour {
	public float speed = 0.0f;
	public float distance = 210.0f;
	public float time = 3.0f;
	public float maxSpeedLimit = 70.0f;
	public float minSpeedLimit = 40.0f;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
	
		speed = distance / time;
		if (speed > maxSpeedLimit) 
		{
			Debug.Log ("You are exceeding the speed limit!");
		} 
		else if (speed < minSpeedLimit) {
			Debug.Log ("You are not going fast enough!");
		}
		else if (speed == maxSpeedLimit || speed == minSpeedLimit);
		{
			Debug.Log ("You are close to breaking the speed the law!");
		}
		else 
		{
			Debug.Log ("You are within the speed limit!");
		}
	}
}

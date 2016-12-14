using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class koroutine : MonoBehaviour {

	void start () 
	{
		StartCoroutine ("Countdown", 10);
	}
	IEnumerator Countdown(int time)
	{
		while (time > 0) {
			Debug.Log (time--);
			yield return new WaitForSeconds (1);
		}
		Debug.Log ("Countdown Complete!");
	}
	}
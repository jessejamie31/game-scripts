﻿using UnityEngine;
using System.Collections;

public class coroutine : MonoBehaviour
{
	public float smoothing = 1f;
	public Transform target;


	void Start ()
	{
		StartCoroutine(MyCoroutine(target));
	}


	IEnumerator MyCoroutine (Transform target)
	{
		while(Vector3.Distance(transform.position, target.position) > 0.5f)
		{
			transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

			yield return null;
		}

		print("Reached the target.");

		yield return new WaitForSeconds(3f);

		print("MyCoroutine is now finished.");
	}
}
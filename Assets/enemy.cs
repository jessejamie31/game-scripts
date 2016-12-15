﻿using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {


		public float forceDuration = 0.1f;
		public bool canAddForce = true;
		private Rigidbody rigid; 
		private float force;
		public float forceRange = 10;
		private Vector3 forceVector;
		private Vector3 torqueVector;
		public float endTime = 3;



		void Start ()
		{
			rigid = GetComponent<Rigidbody> ();
			StartCoroutine (RunRandomForce());
		}

		IEnumerator RunRandomForce ()
		{
			force = Random.Range (-forceRange, forceRange);
			while (canAddForce) {
				yield return new WaitForSeconds (forceDuration);
				forceVector.x = force;
				torqueVector.z -= force * 0.2f;
				rigid.AddTorque (torqueVector);
				rigid.AddForce (forceVector);
			}
		}



		void OnCollisionEnter (Collision other)
		{
			if (other.gameObject.name =="player")

			{
				Destroy (gameObject);

			}	

			Destroy (gameObject, endTime);
			canAddForce = false;

		}
	}


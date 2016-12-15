﻿using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {


		public Transform[] spawnPoints;
		public Transform bullet;
		public float spawnFrequency = 1;
		public bool canSpawnEnemies = true;

		private int i = 0;

		IEnumerator SpawnEnemies()
		{
			while (canSpawnEnemies) 
			{
				i = Random.Range (0, spawnPoints.Length - 1);
				Instantiate (bullet, spawnPoints [i].position, Quaternion.identity);
				yield return new WaitForSeconds (spawnFrequency);
			}
		}

		// Use this for initialization
		void Start () {
			StartCoroutine (SpawnEnemies ());
		}


	}

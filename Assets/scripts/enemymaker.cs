using UnityEngine;
using System.Collections;

public class enemymaker : MonoBehaviour {

	public Transform[] spawnPoints;
	public Transform enemy;
	public float spawnFrequency = 1;
	public bool canSpawnEnemies = true;

	private int i = 0;

	IEnumerator SpawnEnemies()
	{
		while (canSpawnEnemies) 
		{
			i = Random.Range (0, spawnPoints.Length - 1);
			Instantiate (enemy, spawnPoints [i].position, Quaternion.identity);
			yield return new WaitForSeconds (spawnFrequency);
		}
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnEnemies ());
	}


}

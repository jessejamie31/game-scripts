﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private NavMeshAgent myAgent;
	public Transform player;

	// Use this for initialization
	void Start () 
	{
		myAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		myAgent.destination = player.position;
	}
}

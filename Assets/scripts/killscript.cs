using UnityEngine;
using System.Collections;

public class killscript : MonoBehaviour {

	private NavMeshAgent myAgent;
	public Transform player;


	void Start () 
	{
		myAgent = GetComponent<NavMeshAgent> ();
	}
	

	void Update ()
	{
		myAgent.destination = player.position;	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == "player") 
		{
			Destroy (gameObject);
		}
	}
}

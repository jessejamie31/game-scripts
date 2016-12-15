using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 4f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (moveSpeed*Input.GetAxis ("Horizontal") * Time.deltaTime, 0f,moveSpeed*Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}

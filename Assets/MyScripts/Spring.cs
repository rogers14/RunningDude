using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

	public MoveCharacter mc;
	public float springForce = 10.0f;

	void Start()
	{
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<MoveCharacter> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			mc.isSpringed = true;
		}
	}
}

using UnityEngine;
using System.Collections;

public class TurnAround : MonoBehaviour {

	MoveCharacter mc;

	// Use this for initialization
	void Start ()
	{
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<MoveCharacter> ();
	}

	// Reverses direction (WORKS PERFECTLY)
	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			mc.speed *= -1.0f;
			// All hail Dan
			mc.player.transform.rotation = Quaternion.AngleAxis(180, Vector3.up) * mc.player.transform.rotation;
		}
	}
}
using UnityEngine;
using System.Collections;

public class TurnAround : MonoBehaviour {

	MoveCharacter mc;

	// Use this for initialization
	void Start ()
	{
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<MoveCharacter> ();
	}

	// Reverses direction (HAS BUGS!)
	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			mc.speed *= -1.0f;
			mc.player.transform.rotation = Quaternion.Inverse(mc.player.transform.rotation);
		}
	}
}

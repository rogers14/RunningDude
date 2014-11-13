using UnityEngine;
using System.Collections;

public class CharacterDeath : MonoBehaviour {

	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position;
	}

	// Dude hits enemy or runs off edge
	public void die()
	{
		gameObject.transform.position = pos;
	}

	// Player restarts level by pressing R
	public void reset()
	{
		gameObject.transform.position = pos;
	}
}

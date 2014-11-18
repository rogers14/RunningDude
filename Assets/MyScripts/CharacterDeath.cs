using UnityEngine;
using System.Collections;

public class CharacterDeath : MonoBehaviour {

	public ScoreHandler sh;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position;
	}

	// Dude hits enemy or runs off edge
	public void die()
	{
		sh.death ();
		gameObject.transform.position = pos;
	}

	// Player restarts level by pressing R
	public void reset()
	{
		sh.death ();
		gameObject.transform.position = pos;
	}
}

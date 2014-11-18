using UnityEngine;
using System.Collections;

public class CharacterDeath : MonoBehaviour {

	ScoreHandler sh;
	MoveCharacter mc;
	Vector3 pos;

	// Use this for initialization
	void Start () {
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<MoveCharacter> ();
		sh = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreHandler> ();
		pos = gameObject.transform.position;
	}

	// Dude hits enemy or runs off edge
	public void die()
	{
		sh.death ();
		gameObject.transform.position = pos;
		mc.speed = (mc.speed > 0) ? mc.speed : -mc.speed;
	}

	// Player restarts level by pressing R
	public void reset()
	{
		sh.death ();
		gameObject.transform.position = pos;
		mc.speed = (mc.speed > 0) ? mc.speed : -mc.speed;
	}
}

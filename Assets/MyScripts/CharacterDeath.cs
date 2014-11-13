using UnityEngine;
using System.Collections;

public class CharacterDeath : MonoBehaviour {

	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position;
	}

	public void die()
	{
		gameObject.transform.position = pos;
	}
}

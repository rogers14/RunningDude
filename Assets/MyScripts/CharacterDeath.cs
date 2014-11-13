using UnityEngine;
using System.Collections;

public class CharacterDeath : MonoBehaviour {

	Vector3 pos;

	// Use this for initialization
	void Start () {
		pos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void die()
	{
		gameObject.transform.position = pos;
	}
}

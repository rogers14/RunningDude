﻿using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	CharacterDeath cd;
	public float speed = .05f;

	// Use this for initialization
	void Start () {
		cd = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterDeath> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		pos.x -= speed;
		gameObject.transform.position = pos;
		if (pos.x < -16)
						Destroy (gameObject);
	
	}

	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			cd.die();
			Destroy(gameObject);
		}
	}
}
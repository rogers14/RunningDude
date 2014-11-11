﻿using UnityEngine;
using System.Collections;

public class ClickSpawn : MonoBehaviour {

	public GameObject spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
						var pos = Input.mousePosition;
						pos = Camera.main.ScreenToWorldPoint (pos);
			pos.z = 0;
			Instantiate(spawn, pos, transform.rotation);
				}
	
	}
}

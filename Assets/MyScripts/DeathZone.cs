using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	CharacterDeath cd;
	
	void Start()
	{
		cd = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterDeath> ();
	}
	
	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			cd.die();
		}
	}
}

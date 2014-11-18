using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

	public MoveCharacter mc;
	public float springForce = 10.0f;
	public AudioSource sound;

	void Start()
	{
		mc = GameObject.FindGameObjectWithTag ("Player").GetComponent<MoveCharacter> ();
	}

	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			mc.isSpringed = true;
			sound.Play();
		}
	}
}

using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	CharacterDeath cd;
	public float speed = .05f;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
		cd = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterDeath> ();
		startPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = gameObject.transform.position;
		pos.x -= speed;
		gameObject.transform.position = pos;

		if (pos.x < -16 || pos.x > 16)
		{
			speed = -speed;
		}
	}

	void OnTriggerEnter (Collider c) 
	{
		if (c.tag == "Player")
		{
			cd.die();
			//Destroy(gameObject);
		}
	}

	// BUGS -- spawns a bunch of enemies instead of resetting the original
	// Also, doesn't work if enemy was killed . . .
	public void Reset()
	{
		gameObject.transform.position = startPos;
	}
}

using UnityEngine;
using System.Collections;

public class ResetCharacter : MonoBehaviour {

	CharacterDeath cd;
	
	void Start()
	{
		cd = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterDeath> ();
	}
	
	void Update()
	{
		// R to reset
		if (Input.GetKey (KeyCode.R))
		{
			cd.reset ();  // Player

			// Placed items
			GameObject[] items = GameObject.FindGameObjectsWithTag("PlacedItem");
			for (int i = 0; i < items.Length; i++)
			{
				DestroyObject(items[i]);
			}
		}
	}
}

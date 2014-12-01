using UnityEngine;
using System.Collections;

public class RCEnemyScript : MonoBehaviour {
	
	CharacterDeath cd;
	FinishLine fl;
	EnemyScript en;
	
	void Start()
	{
		cd = GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterDeath> ();
		fl = GameObject.FindGameObjectWithTag ("Finish").GetComponentInChildren<FinishLine> ();
		en = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyScript>();
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
			
			// Resets text
			fl.finishText.text = "";
			
			// Resets Enemies
			en.Reset();
		}
	}
}

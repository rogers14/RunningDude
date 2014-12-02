using UnityEngine;
using System.Collections;

public class ClickSpawn : MonoBehaviour {

	ScoreHandler sh;
	GUITexture inventory;
	public GameObject[] spawns;
	public Texture[] images;
	int selected = 0;

	// Use this for initialization
	void Start () {
		sh = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreHandler> ();
		inventory = GameObject.Find ("Inventory").GetComponent<GUITexture> ();
	}
	
	// Update is called once per frame
	void Update () {
		//left click to place item
		if (Input.GetMouseButtonDown (0)) {
						var pos = Input.mousePosition;
						pos = Camera.main.ScreenToWorldPoint (pos);
			pos.z = 0;
			Object instance = Instantiate(spawns[selected], pos, spawns[selected].transform.rotation);
			sh.itemPlace();
				}
		//right click to remove item
		if (Input.GetMouseButtonDown (1)) {
			Vector3 pos = Input.mousePosition;
			pos = Camera.main.ScreenToWorldPoint (pos);
			RaycastHit hit = new RaycastHit();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast(pos, Vector3.forward, out hit, 9.99f)){
				if(hit.collider.tag == "PlacedItem")
					Destroy(hit.collider.gameObject);
			}
		}

		// Spring
		if(Input.GetKeyDown(KeyCode.Alpha1)) {
			selected = 0;
			inventory.texture = images[0];
		}

		// Platform
		if(Input.GetKeyDown(KeyCode.Alpha2)) {
			selected = 1;
			inventory.texture = images[1];
		}

		// Wall
		if(Input.GetKeyDown(KeyCode.Alpha3)) {
			selected = 2;
			inventory.texture = images[2];
		}
	}
}

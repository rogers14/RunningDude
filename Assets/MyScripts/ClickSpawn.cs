using UnityEngine;
using System.Collections;

public class ClickSpawn : MonoBehaviour {

	public GameObject[] spawns;
	int selected = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
						var pos = Input.mousePosition;
						pos = Camera.main.ScreenToWorldPoint (pos);
			pos.z = 0;
			Instantiate(spawns[selected], pos, transform.rotation);
				}
		if(Input.GetKeyDown(KeyCode.Alpha1)) {
			selected = 0;

		}
		if(Input.GetKeyDown(KeyCode.Alpha2)) {
			selected = 1;
			
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)) {
			selected = 2;
			
		}
	
	}
}

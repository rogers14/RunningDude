using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	ScoreHandler sh;
	public GUIText finishText;

	void Start()
	{
		finishText.text = "";
		sh = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreHandler> ();
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
						finishText.text = "You beat the level! Score: " + sh.score;
			if(Application.loadedLevel == 0) {
			   Application.LoadLevel (1);
			   }
			else if(Application.loadedLevel == 1) {
				Application.LoadLevel (2);
			}
			else if(Application.loadedLevel == 2) {
				Application.LoadLevel (3);
			}
			else if(Application.loadedLevel == 3) {
				Application.LoadLevel (4);
			}
			else if(Application.loadedLevel == 4) {
				Application.LoadLevel (5);
			}
			else if(Application.loadedLevel == 5) {
				Application.LoadLevel (6);
			}
			else if(Application.loadedLevel == 6) {
				finishText.text = "You Win!";
			}
		}
	}
}

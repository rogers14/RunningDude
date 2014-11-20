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
						finishText.text = "You Win! Score: " + sh.score;
			if(Application.loadedLevel == 0) {
			   Application.LoadLevel (1);
			   }
				}
	}
}

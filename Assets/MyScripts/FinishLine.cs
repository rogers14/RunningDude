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
		finishText.text = "You Win! Score: " + sh.score;
	}
}

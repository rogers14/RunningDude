using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	public ScoreHandler sh;
	public GUIText finishText;

	void Start()
	{
		finishText.text = "";
	}

	void OnTriggerEnter(Collider c)
	{
		finishText.text = "You Win! Score: " + sh.score;
	}
}
